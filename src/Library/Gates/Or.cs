namespace Gates;

public class OR : IGate
{
    List<IInput> inputs {get ; set ;}

    public OR()
    {
        this.inputs = new List<IInput>();
    }

    public bool GetValue()
    {
        return this.Calculate();
    }
    
    public bool Calculate()
    {
        bool result = true;
        foreach(bool item in inputs)
        {
            result += item.GetValue();
        }
        return result;
    }
}