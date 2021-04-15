using System;

class GMLVariableDoesNotExistException : Exception
{
    public GMLVariableDoesNotExistException(string name, int position) : base("Variable with identifier\""+name+"\" at line ("+name+")")
    {

    }
}
