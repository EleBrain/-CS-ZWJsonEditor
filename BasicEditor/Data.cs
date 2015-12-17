﻿using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public int FieldWidth { get; set; }
    public int FieldHeight { get; set; }
    public int NowTurn { get; set; }
    public int OrderNumber { get; set; }
    public int[] OrderList { get; set; }


    public Data() { }
    public Data(string name, int fieldWidth, int fieldHeight, int nowTurn, int orderNumber, int[] orderList) {
        Name = name;
        FieldWidth = fieldWidth;
        FieldHeight = fieldHeight;
        NowTurn = nowTurn;
        OrderNumber = orderNumber;
        OrderList = orderList;
    }
    public override string ToString() {
        return Name;
    }
}