using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GMLSymbolTable
{
    private Dictionary<string, object> table;

    public GMLSymbolTable()
    {
        table = new Dictionary<string, object>();
    }

    public void setValue(string key, object value)
    {
        table[key] = value;
    }

    public object getValue(string key)
    {
        return table[key];
    }
}
