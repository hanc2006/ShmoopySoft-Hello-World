/*
 * MIT License
 * 
 * Copyright(c) 2020 ShmoopySoft (Pty) Ltd
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
 * associated documentation files (the "Software"), to deal in the Software without restriction, including 
 * without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 * copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial 
 * portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
 * LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO 
 * EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
 * USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;

namespace ShmoopySoft_Hello_World
{
    /// <summary>
    /// The Program class's responsibility is to provide an entry point for the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// C# applications have an entry point called the Main Method. 
        /// It is the first method that gets invoked when an application starts.
        /// </summary>
        /// <param name="args">Command line arguments as string type parameters</param>
        static void Main(string[] args)
        {
            // Write to the console.
            Console.WriteLine("Hello, World!");

            // Wait for a key press.
            Console.ReadKey(true);
        }
    }
}
