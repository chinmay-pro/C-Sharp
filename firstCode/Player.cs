namespace firstCode
{
    class Player
    {
      /*  public string name;
        public string Name{
            get { return name; }
            set { name = value;}
        } */

            public string Name
               { get; set; }
        

        private int health = 56;
        public void setHealth(int h)
        {
             health = h;
        }
        public int getHealth()
        {
             return health;
        }
    }
}