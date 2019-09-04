namespace webshellManager
{
    public class Folder
    {
        public string name { get; set; }
        public string size { get; set; }
        public string permisions { get; set; }

        public Folder(string pName, string pSize, string pPerms)
        {
            this.name = pName;
            this.size = pSize;
            this.permisions = pPerms;
        }
    }
}