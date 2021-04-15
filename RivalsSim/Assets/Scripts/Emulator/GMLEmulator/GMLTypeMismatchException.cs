using System;

class GMLTypeMismatchException : Exception
{
    public GMLTypeMismatchException(){}

    public GMLTypeMismatchException(string funcName, int position, Type expected, Type received) : base("Variable of Type " + expected.Name + " cannot be cast to Type " + received.Name + " at line("+position+").")
    {}

}
