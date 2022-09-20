namespace Gates;

public class NOT : IGate
{
    IInput inputs {get ; set ;}

    public NOT()
    {
        this.inputs = new List<IInput>();
    }

    public bool GetValue()
    {
        return this.Calculate();
    }
    
    public bool Calculate()
    {
        if (inputs == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}