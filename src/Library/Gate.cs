using System.Collections;

namespace Gates;

public class Gate 
{
    public string ID {get ; set ;}
    public List<bool> Input {get ; set ;}
    public bool Output = Calculate(Input,OperationType);
    
    enum Type
    {
        AND,
        OR,
        NOT
    }

    public Gate(string ID)
    {
        this.ID = ID;
    }

    public bool Calculate(List<bool> Input, Type OperationType)
    {
        if(OperationType == Type.AND)
        {
            bool result = 1;
            foreach (bool individualProduct in Input)
            {
                result = result * individualProduct;
            }
            return result;
        }
        else if(OperationType == Type.OR)
        {
            bool result = 0;
            foreach (bool individualAdd in Input)
            {
                result = result + individualAdd;
            }
            return result;
        }
        else if(OperationType == Type.NOT)
        {
            if(Input[0] == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return null;
        }
    }
}