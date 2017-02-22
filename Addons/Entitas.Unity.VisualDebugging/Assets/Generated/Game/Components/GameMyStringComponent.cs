//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyStringComponent myString { get { return (MyStringComponent)GetComponent(GameComponentsLookup.MyString); } }
    public bool hasMyString { get { return HasComponent(GameComponentsLookup.MyString); } }

    public void AddMyString(string newMyString) {
        var component = CreateComponent<MyStringComponent>(GameComponentsLookup.MyString);
        component.myString = newMyString;
        AddComponent(GameComponentsLookup.MyString, component);
    }

    public void ReplaceMyString(string newMyString) {
        var component = CreateComponent<MyStringComponent>(GameComponentsLookup.MyString);
        component.myString = newMyString;
        ReplaceComponent(GameComponentsLookup.MyString, component);
    }

    public void RemoveMyString() {
        RemoveComponent(GameComponentsLookup.MyString);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMyString;

    public static Entitas.IMatcher<GameEntity> MyString {
        get {
            if(_matcherMyString == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyString);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyString = matcher;
            }

            return _matcherMyString;
        }
    }
}