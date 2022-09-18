# cs-con-string-int

```cs
// ****************************
// 文字列を整数に変換
// ****************************
var su = "123";
var result = int.Parse(su);
result++;
result += 2;
result = result + 2;
print(result);

// ****************************
// 整数を文字列に変換
// ****************************
var text = string.Format("{0}", result);
print(text);

text = $"{result}";
print(text);

// 簡易的な方法
text = result + "";
print(text);

```
