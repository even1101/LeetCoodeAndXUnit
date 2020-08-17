# Unit Test LeetCode

## Unit Test Main 3 Step
* Step1. Arrange (創建實體)
* Step2. Act      (取得結果)
* Step3. Assert   (驗證結果正確性)

## XUnit 建構式 注入
*ITestOutputHelper 可以輸出log


## XUnit Attr 用法
* [Fact] 標註為測試方法 ** [Fact(Skip="略過測試")] 
* [Trait("name", "value")] 依照群組分類 可用於class or method
*
## 多組資料測試
* [Fact] 可替換成[Theory] 多組資料測試
* [InlineData(p1,p2, expected)] 第一組參數 可設多組參數
** 或把InLineData改成從某個地方來可以共享測試資料
* [MemberData(paras, type)]

## 自定義Xunit Attr
** 繼承 DataAttribute 並實作 GetData方法


