namespace Gates;

public class AND : IGate
{
    List<IInput> inputs {get ; set ;}

    public AND()
    {
        this.inputs = new List<IInput>();
    }

    public bool GetValue()
    {
        return this.Calculate();
    }
    
    public bool Calculate()
    {
        bool result = false;
        foreach(bool item in inputs)
        {
            result *= item.GetValue();
        }
        return result;
    }
}