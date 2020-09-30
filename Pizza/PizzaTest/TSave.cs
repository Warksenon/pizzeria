﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;

namespace PizzaTest
{
    class TSave
    {
        TISaveHistory save;
        public enum ChoiceSaveOrder
        {
            Sql,
            Txt
        }
        public void  SaveOrderList (ChoiceSaveOrder en, List<Order> orders)
        {            
            switch (en)
            {
                case ChoiceSaveOrder.Sql:
                    save = new TInsertAndQuestionSQL(); break;
                case ChoiceSaveOrder.Txt:
                    save = new TSaveFiles(); break;
                default:
                    save = new TInsertAndQuestionSQL(); break;
            }
            save.SaveHistoryOrders(orders);
        }

        public void SaveOrder(ChoiceSaveOrder en, Order order)
        { 
            switch (en)
            {
                case ChoiceSaveOrder.Sql:
                    save = new TInsertAndQuestionSQL(); break;
                case ChoiceSaveOrder.Txt:
                    save = new TSaveFiles(); break;
                default:
                    save = new TInsertAndQuestionSQL(); break;
            }
            save.AddOrder(order);
        }
    }  
}