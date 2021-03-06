﻿using System;
using Contracts.OrderManagement;
using Interfaces;
using Ordering.BusinessLogic.OrderManagement;
using ProcessManagement;

namespace TestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var TestOrder = new OrderManager(123, "Jordan");
            //TestOrder.AddItem("hello", 1);
            //TestOrder.AddItem("hello", 1);
            //TestOrder.AddItem("hi", 3);

            //TestOrder.ViewOrder();
            //Console.WriteLine(TestOrder.NewOrder.UserName);

            TestOrderProcess();
        }

        public static void TestOrderProcess()
        {
            var orderProcess = new OrderProcess(1);
            Console.WriteLine("Order Created - Current Step: {0}", orderProcess.CurrentStep);

            orderProcess.MoveToNextStep();
            Console.WriteLine("MoveToNextStep 1 - Current Step: {0}", orderProcess.CurrentStep);

            orderProcess.MoveToNextStep();
            Console.WriteLine("MoveToNextStep 2 - Current Step: {0}", orderProcess.CurrentStep);

            orderProcess.MoveToNextStep();
            Console.WriteLine("MoveToNextStep 3 - Current Step: {0}", orderProcess.CurrentStep);

            orderProcess.MoveToNextStep();
            Console.WriteLine("MoveToNextStep 4 - Current Step: {0}", orderProcess.CurrentStep);

            orderProcess.MoveToNextStep();
            Console.WriteLine("MoveToNextStep 5 - Already Completed - Current Step: {0}", orderProcess.CurrentStep);
        }
    }
}
