namespace _00_Borra
{
    public partial class Form1 : Form
    {

        BindingNavigator bn;
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            LoadNavigator();
        }

 
        private void LoadNavigator()
        {
            // 1. Instanciar con 'true' para que cree automáticamente los botones (Next, Previous, etc.)
            bn = new BindingNavigator(true);
            bs = new BindingSource();

            // 2. Configurar propiedades básicas
            //bn.Location = new Point(10, 200); // Normalmente va en (0,0) o se acopla arriba
            bn.Dock = DockStyle.Bottom;      // Lo habitual es que esté anclado en la parte superior

            // 3. Vincularlo a tu origen de datos (BindingSource)
            // Es imprescindible para que los botones no aparezcan deshabilitados
            bn.BindingSource = bs;

            // 4. IMPORTANTE: Agregarlo a los controles del formulario para que sea visible
            this.Controls.Add(bn);

        }
    }
}
