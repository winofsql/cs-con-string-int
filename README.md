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

text = result.ToString();
print(text);

text = result.ToString("0000");
print(text);

text = (result+100000).ToString("###,##0");
print(text);
text = (result+100000).ToString("00-00-00");
print(text);

text = string.Format("{0:###,###}", 0);
print(text);
text = string.Format("{0:###,##0}", 0);
print(text);
```
