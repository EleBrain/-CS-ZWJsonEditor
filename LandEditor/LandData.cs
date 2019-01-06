using System.ComponentModel;


[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class LandData {

    public string ID { get; set; }
    public string Name { get; set; }

    //イメージ画像の名前
    public string AnimeName { get; set; }

    //移動コストのインデックス
    public int MoveCostIndex { get; set; }

    //生み出す資源
    public int[] Prodacts { get; set; }

    //マスに止まったらイベント　など追加したい
    //conditionName   条件
    // 起こること スキルにする?

    public LandData() { }

    public override string ToString() {
        return ID;
    }

}
