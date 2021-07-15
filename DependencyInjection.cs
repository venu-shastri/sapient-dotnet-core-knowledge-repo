public class TataOmegaCar
    {
        IKineticEnergyProvider _engineRef;
        //field
        private IMultiMediaSystem _multiMediaSystem;
        IOpaquePanel _panel;

        //Constructor Injection
        public TataOmegaCar(IKineticEnergyProvider engine)
        {

            if (engine == null) { throw new NullReferenceException(); }
            this._engineRef = engine;

        }

        //Setter Injection or Property Injection 
        public IMultiMediaSystem MultiMediaSystem
        {
            get
            {
                return this._multiMediaSystem;
            }
            // public void set_MultiMediaSystem(IMultiMediaSystem value)
            set
            {
                this._multiMediaSystem = value;
            }
        }
        public IOpaquePanel Panel
        {
            get { return this._panel; }
            set { this._panel = value; }
        }
        //    public TataOmegaCar(IKineticEnergyProvider engine,IMultiMediaSystem multiMediaSystem):this(engine)
        //    {


        //        this._multiMediaSystem = multiMediaSystem;
        //    }

        //    public TataOmegaCar(IKineticEnergyProvider engine, IOpaquePanel panel):this(engine)
        //    {


        //        this._panel = panel;
        //    }
        //    public TataOmegaCar(IKineticEnergyProvider engine, IMultiMediaSystem multiMediaSystem,IOpaquePanel panel):this(engine,multiMediaSystem)
        //    {


        //        this._panel = panel;
        //    }
        //}
        public interface IKineticEnergyProvider
        {
            void Ignite();
            void Stop();

        }

        //Service Provider (Low Level Module)
        class DicorEngine : IKineticEnergyProvider
        {
            public void Ignite()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

        class VeriCoreEngine
        {

        }

        class KryotecEngine
        {

        }
        class RevortronEngine
        {

        }

        public interface IMultiMediaSystem
        {

        }
        class BoseSystem : IMultiMediaSystem
        {

        }

        class HMSystem : IMultiMediaSystem
        {

        }

        public interface IOpaquePanel { }
        class SunRoof : IOpaquePanel
        {

        }
        class PanaromaSunroof : IOpaquePanel
        {


        }

        class SkyRoof : IOpaquePanel
        {


        }


    }
