namespace webshellManager
{
    public class File
    {
        public string name { get; set; }
        public string size { get; set; }
        public string permisions { get; set; }
        public string type { get; set; }
        public string lastMod { get; set; }

        public File(string pName, string pSize, string pPerms, string lMod, string pType)
        {
            this.name = pName;
            this.size = pSize;
            this.type = pType;
            this.permisions = pPerms;
            this.lastMod = lMod;
        }
    }
}