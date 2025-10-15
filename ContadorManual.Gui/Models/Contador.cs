
namespace ContadorManual.Gui.Mains
{
    class Contador
    {
        private int _conteo;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {

                    _conteo = value;
                }
            }


        }
      public Contador()
        {
            Conteo = 0;
        }

        public void contar()
        {
            Conteo++;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }
    } }
