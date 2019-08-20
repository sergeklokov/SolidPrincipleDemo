using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLIbrary
{
    // S is single responsibility principle(SRP)
    // O stands for open closed principle(OCP)
    // L Liskov substitution principle(LSP)
    // I interface segregation principle(ISP)
    // D Dependency injection principle(DIP)


    interface IEmailGenerator
    {
        void SendEmail(string s);
    };

    interface IEmailGeneratorHTML
    {
        void SendEmailHTML(string s);
    };

    // Separate class with Single responsibility (send email)
    public class EmailGeneratorPlain: IEmailGenerator
    {
        public void SendEmail(string s)
        {
            // send email with info about this object
            Console.WriteLine("Email sent with this info: " + s);
        }


        // This is violation of Open closed principle
        // It should be closed for modification
        public void SendEmailFormatted(string emailFormat)
        {
            if (emailFormat == "plain")
                Console.WriteLine("Send email plain text");
            else
                Console.WriteLine("Send email HTML");

        }
    }

    // using  Open closed principle (open for extension)
    public class EmailGeneratorHTML : IEmailGenerator, IEmailGeneratorHTML
    {
        public void SendEmail(string s)
        {
            // send email with info about this object
            Console.WriteLine("Email sent with this info: " + s);
        }

        public void SendEmailHTML(string s)
        {
            // send email with info about this object
            Console.WriteLine("HTML Email sent with this info: " + s);
        }
    }
}
