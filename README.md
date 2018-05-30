# TDD-Kata-Mumbling

The examples below show you how to write function accum:

Examples:

```csharp
Accumul.Accum("abcd");    // "A-Bb-Ccc-Dddd"
Accumul.Accum("RqaEzty"); // "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
Accumul.Accum("cwAt");    // "C-Ww-Aaa-Tttt"
```

The parameter of accum is a string which includes only letters from a..z and A..Z.

中文說明：
- 輸入一個字串, 每個字元依其位置重複，中間以"-"連接。
- 每個字母重複的首字母大寫，其他的要轉成小寫。
- 可輸入的字元為英文字母的小寫a-z及大寫A-Z

Test case 整理
https://embed.coggle.it/diagram/Ww11f-fgI0jIAmQc/35d58eb05824b9770b272f0b79df649886e83a3c25888e214becdcb1538852ad
