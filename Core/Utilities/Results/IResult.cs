using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //TEMEL VOİDLERİ İÇİN BASLANGIC
    public interface IResult
    {

        bool Success { get; }
        string Message { get; }
    }
}
