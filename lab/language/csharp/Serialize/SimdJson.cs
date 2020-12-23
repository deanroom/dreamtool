﻿using System.Text;
using System;
using SimdJsonSharp;
namespace serialize
{
    public class SimdJson
    {
        static unsafe void Run()
        {
           string helloWorldJson = @"{ ""answer"": 42, ""name"": ""Egor"" }";
                    var bytes = Encoding.UTF8.GetBytes(helloWorldJson);
        
                    fixed (byte* ptr = bytes)
                    {
                        // SimdJsonN -- N stands for Native, it means we are using Bindings for simdjson native lib
                        // SimdJson -- fully managed .NET Core 3.0 port
                        using (ParsedJso doc = SimdJsonN.ParseJson(ptr, (int)bytes.Length))
                        {
                            if (!doc.IsValid)
                            {
                                Console.WriteLine("Error: " + doc.ErrorCode);
                                return;
                            }
        
                            Console.WriteLine("Json is valid!");
        
                            //open iterator:
                            using (var iterator = new ParsedJsonIterator(doc))
                            {
                                while (iterator.MoveForward())
                                {
                                    if (iterator.IsInteger)
                                        Console.WriteLine("integer: " + iterator.GetInteger());
                                    if (iterator.IsString)
                                        Console.WriteLine("string: " + iterator.GetUtf16String());
                                }
                            }
                        }

        }
        }
}