﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Meowv.Blog.HelloWorld.Impl
{
    public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "HelloWorld";
        }
    }
}
