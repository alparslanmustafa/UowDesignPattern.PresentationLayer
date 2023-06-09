﻿namespace UowDesignPattern.PresentationLayer.Models
{
    public class ProcessViewModel
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public decimal Amount { get; set; }
        public decimal SenderNewBalance { get; set; }
        public decimal ReceiverNewBalance { get; set; }       
    }
}
