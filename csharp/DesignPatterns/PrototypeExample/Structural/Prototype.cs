﻿namespace PrototypeExample.Structural
{
    abstract class Prototype
    {
        public Prototype(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public abstract Prototype Clone();
    }
}
