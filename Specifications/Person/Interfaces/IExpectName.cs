﻿namespace SpecificationDemo.Specifications.Person.Interfaces
{
    public interface IExpectName
    {
        IExpectSurname WithName(string name);
    }
}