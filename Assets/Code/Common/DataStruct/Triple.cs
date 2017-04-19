﻿using UnityEngine;
using System.Collections;

public struct Triple<A, B, C>
{
    public A a;
    public B b;
    public C c;

    public Triple(A a, B b, C c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
}
