namespace Opgave02.model;

public record Charactor(
    string FullName,
    string Nickname,
    string HogwartsHouse,
    string InterpretedBy,
    List<string> Children,
    string Image,
    string Birthdate,
    int Index
    );
