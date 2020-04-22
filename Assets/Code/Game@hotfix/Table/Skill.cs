//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game.Data
{
    using System;
    using System.Collections.Generic;
    using Game.Data;
    using SQLite4Unity3d;
    
    
    public class Skill
    {
        
        // 技能
      [PrimaryKey] 
        public double Id {get;set;}
        // 技能名
       public string Name {get;set;}
        // 下一级ID
       public double NextLevelID {get;set;}
        // 是否被动技能
       public bool IsPassive {get;set;}
        // Buff列表
       public List<double> Buffs {get;set;}
        // 攻击单位
       public double AttackNum {get;set;}
        // 攻击系数
       public List<double> AttackRatio {get;set;}
        // 攻击次数
       public double AttackCount {get;set;}
        // 图标
       public string Icon {get;set;}
        // 技能描述
       public string Des {get;set;}
        // 特效路径
       public string Effect {get;set;}
        // 特效类型
       public double EffectType {get;set;}
    }
}
