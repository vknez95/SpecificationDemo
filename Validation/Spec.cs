﻿using System;
using SpecificationDemo.Validation.Infrastructure;

namespace SpecificationDemo.Validation
{
    public static class Spec<T>
    {
        public static Specification<T> NotNull<TProperty>(Func<T, TProperty> propertyGetter) =>
            new Property<T, TProperty>(propertyGetter, new NotNull<TProperty>());

        public static Specification<T> Null<TProperty>(Func<T, TProperty> propertyGetter) =>
            NotNull(propertyGetter).Not();

        public static Specification<T> IsTrue(Func<T, bool> predicate) =>
            new Infrastructure.Predicate<T>(predicate);

        public static Specification<T> NonEmptyString(Func<T, string> propertyGetter) =>
            new Property<T, string>(propertyGetter, new NonEmptyString());

    }
}
