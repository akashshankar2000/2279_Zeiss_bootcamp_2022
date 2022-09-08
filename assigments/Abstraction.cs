using System;

namespace ConsoleApp16.WhyAbstract
{
   
    public class Program
    {
        static void Main()
        {
    
            SearchWindow _searchWindow = new SearchWindow();
            _searchWindow.Draw();
        }
    }


    public abstract class Control
    {
        public string ControlId, ToolTip;
        public double Height, Width;
        
        public abstract void Draw();
        //implentation code re-use, variation of each fn for Draw method
    }

    public class TextBox:Control
    {
        
        public string Text;
        public override void Draw()
        {

            Console.WriteLine("TextBox Draw");
        }
        
    }
    public class Button:Control
    {
        
        public string Caption;
        public override void Draw()
        {
            Console.WriteLine("Button Draw");
        }
    }
    public class Window:Control
    {
	List<Control> controls = new List<control>();        
        public string Title;
        public override void Draw()
        {
            Console.WriteLine("Window Draw");
    	    foreach(Control ctr in controls)
    	    {
    		    ctr.Draw();
    	    }
        }
    }

    public class SearchWindow : Window
    {
        TextBox _textBox = new TextBox();
        Button _button = new Button();
    }

}
