namespace ConsoleApp16
{

    public class TataCar
    {
        
	IEngineType _engineType;
	//Depending on abstraction of car, Constructor injection
	public TataCar(IEngineType engine)
	{
		this._engineType = engine;
	}
        //RevtronEngine _engine=new RevtronEngine(); //composition
        public void Ignite() {
        	_engine.Start();
        }
        public void Halt() {
            _engine.Stop();
        }
    }

interface IEngine
{
	void Start() { }

        void Stop() { }
}

public class RevtronEngine : IEngine
{
	public void Start()
	{
		Console.WriteLine("Revtron is ignited");
	}
	public void Stop()
	{
	}
}
public class Vericore: IEngine
{
	public void Start()
	{
		Console.WriteLine("Vericore is ignited");
	}
	public void Stop()
	{
	}
}
public class Kryotech : IEngineType
{
	public void Start()
	{
		Console.WriteLine("Kryotech is ignited");
	}
	public void Stop()
	{
	}
}

internal class Program
    {
        static void Main(string[] args)
        {
	    IEngineType _engine = new RevtronEngine()
            TataCar _nexon = new TataCar(_engine);
            _nexon.Ignite();
       
            _engine = new KryotechEngine();
            TataCar _harrier = new TataCar();
	    _harrier.Ignite();

            TataCar _hexa = new TataCar();
        }
    }
