using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string ID { get; set; }
    public string Name { get; set; }

    //イメージ画像のインデックス
    public int SpriteNumber { get; set; }

    //移動コストのインデックス
    public int MoveCostIndex { get; set; }

    //生み出す資源
    public int[] Prodacts { get; set; }

    //マスに止まったらイベント　など追加したい
    //conditionName   条件
    // 起こること スキルにする?

    public Data() { }
    public Data(string name, int spriteNumber, int moveCostIndex, int[] prodacts) {
        Name = name;
        SpriteNumber = spriteNumber;
        Prodacts = prodacts;
        MoveCostIndex = moveCostIndex;
    }

    public override string ToString() {
        return ID;
    }

}
