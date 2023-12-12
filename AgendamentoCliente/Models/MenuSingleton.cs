namespace AgendamentoCliente.Models
{
    internal class MenuSingleton
    {

        public Telas.Menu Menu { get; set; }
        private MenuSingleton(Telas.Menu menu)
        {
            this.Menu = menu;
        }

        public void MenuVisible()
        {
            this.Menu.Visible = true;
        }

        private static MenuSingleton instance;

        public static void createInstance(Telas.Menu menu)
        {
            instance = new MenuSingleton(menu);
        }

        public static MenuSingleton Instance
        {

            get
            {
                if (instance == null)
                {
                    throw new NullReferenceException();
                }
                return instance;
            }
        }
    }
}
