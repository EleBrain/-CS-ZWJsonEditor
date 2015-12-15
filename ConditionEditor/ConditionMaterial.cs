using System;
using System.Collections;
using System.Collections.Generic;

public class ConditionMaterial {

    public string Target { get; set; }

    //比較方法
    public ComparisonType TargetComparison { get; set; }
    public ComparisonType CountComparison { get; set; }

    //参照する値
    public string Calc { get; set; }

    public int NeedCount { get; set; }


    public ConditionMaterial() { }
    public ConditionMaterial(string target, ComparisonType targetComp, string calc, int needCount,ComparisonType countComp) {
        Target = target;
        TargetComparison = targetComp;
        Calc = calc;
        NeedCount = needCount;
        CountComparison = countComp;
    }
}

//プレイヤーの場合
//自分　チーム 自分以外　チーム以外　xからy a,c,f                                

//m a s v p
//自分　全体　選択　そのままの値　プレイヤー チーム       

//m s
//rangename
//r p sk st m o t

//a フィールド全体
//r p sk st m o t

//p  プレイヤー
//どのプレイヤーを見るか
//r p sk st m t



//p ta sk st r m o te
//名前

//パワーなどの場合
//p r o te
//値 

//タグなどの場合
//いらない


//m r 回り１マス o 1 Not 1
//自分の位置から　レンジ レンジ名 オーナー　自分の値（チーム） 以外 そのユニットがいくつ以上必要か
//どうやって自分のチームを得るか　１つずつ作っていくしかないか?

//周りに自分のチーム以外のユニットがいれば
//target m rangeName   o 
//not
//calc v 1 
//value 1

//周りにあるタグのユニットがいれば
//target m rangeName t タグネーム 
//not
//value 1

//あるリソースが５以上なら
//target p   オーナー番号？ r リソースネーム
//not
//calc  s rangenamge0,0 + v 10
//value 5 
//プレイヤーがだれか決めるようにするには？


//全プレイヤーの中でx人が条件を満たしている場合を作るとしたら?
//p all r rn
//over
//calc  v 10


//自分のパワーが１０以上なら
//target m rangeName(自分自身)  p PowerName
//over
//calc  v 10
//value 5 


//自分のパワーが選択したユニットの防御+10を上回っていれば以上なら
//target m rangeName0,0  p PowerName
//over
//calc  s rangenamge0,0 p 防御 + v 10
//value 1 


public enum ConditionUnitTargetType {
    Me,
    Select,
    All,
    Player,
    Team,
}
public enum ConditionValueTargetType {
    None,
    Power,
    Tag,
    Skill,
    State,
    Resource,
    MoveType,
    Owner,
    Team,
    Land,
}

public enum ComparisonType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
}
