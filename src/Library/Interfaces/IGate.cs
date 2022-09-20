using System.Collections;

namespace Gates;

interface IGate : IInput
{
    public string Name {get ; set ;}
    public IInput Input {get ; set ;}
    
    public bool Calculate();

}