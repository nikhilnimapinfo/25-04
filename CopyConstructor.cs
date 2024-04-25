namespace ExpectionHandeling_Program
{
    public class CopyConstructor {
        public int id;
        public string Name;

        public CopyConstructor(CopyConstructor c) {
            id = c.id;
            Name = c.Name;
        }


        public CopyConstructor(int idd, string namee)
        {
            this.id = idd;
            this.Name = namee;
        }
    
    }
}
