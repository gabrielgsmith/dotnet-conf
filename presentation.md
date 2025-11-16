---
marp: true
math: mathjax
theme: rose-pine
# theme: rose-pine-dawn
# theme: rose-pine-moon
---

<style lang=css>
/*
Rosé Pine theme create by RAINBOWFLESH
> www.rosepinetheme.com

palette in :root
*/

@import "default";
@import "schema";
@import "structure";

:root {
  --base: #232136;
    --surface: #2a273f;
    --overlay: #393552;
    --muted: #6e6a86;
    --subtle: #908caa;
    --text: #e0def4;
    --love: #eb6f92;
    --gold: #f6c177;
    --rose: #ea9a97;
    --pine: #3e8fb0;
    --foam: #9ccfd8;
    --iris: #c4a7e7;
    --highlight-low: #2a283e;
    --highlight-muted: #44415a;
    --highlight-high: #56526e;

  font-family: Pier Sans, ui-sans-serif, system-ui, -apple-system,
    BlinkMacSystemFont, Segoe UI, Roboto, Helvetica Neue, Arial, Noto Sans,
    sans-serif, "Apple Color Emoji", "Segoe UI Emoji", Segoe UI Symbol,
    "Noto Color Emoji";
  font-weight: initial;

  background-color: var(--base);
}
/*Common style*/
h1 {
  color: var(--rose);
  padding-bottom: 2mm;
  margin-bottom: 12mm;
}
h2 {
  color: var(--rose);
}
h3 {
  color: var(--rose);
}
h4 {
  color: var(--rose);
}
h5 {
  color: var(--rose);
}
h6 {
  color: var(--rose);
}
a {
  color: var(--iris);
}
p {
  font-size: 20pt;
  font-weight: 600;
  color: var(--text);
}
code {
  color: var(--text);
  background-color: var(--highlight-muted);
}
text {
  color: var(--text);
}
ul {
  color: var(--subtle);
}
li {
  color: var(--subtle);
}
img {
  background-color: var(--highlight-low);
}
strong {
  color: var(--text);
  font-weight: inherit;
  font-weight: 800;
}
mjx-container {
  color: var(--text);
}
marp-pre {
  background-color: var(--overlay);
  border-color: var(--highlight-high);
}

/**/
.columns {
  display: grid;
  grid-template-columns: repeat(2, minmax(0, 1fr));
  gap: 1rem;
}

/*Code blok*/
.hljs-comment {
  color: var(--muted);
}
.hljs-attr {
  color: var(--foam);
}
.hljs-punctuation {
  color: var(--subtle);
}
.hljs-string {
  color: var(--gold);
}
.hljs-title {
  color: var(--foam);
}
.hljs-keyword {
  color: var(--pine);
}
.hljs-variable {
  color: var(--text);
}
.hljs-literal {
  color: var(--rose);
}
.hljs-type {
  color: var(--love);
}
.hljs-number {
  color: var(--gold);
}
.hljs-built_in {
  color: var(--love);
}
.hljs-params {
  color: var(--iris);
}
.hljs-symbol {
  color: var(--foam);
}
.hljs-meta {
  color: var(--subtle);
}

</style>

<!-- _class: invert -->
<!-- _paginate: false -->

# .NET Conf 2025

## モダン開発の未来

### 2025年11月11日〜13日

---

<!-- Speaker Notes: 30秒
皆さん、ようこそ!本日は.NET Conf 2025の素晴らしい発表について深掘りしていきます。これはMicrosoftの.NETエコシステムにおけるフラッグシップ開発者イベントです。
-->

# スピーカーについて

**[お名前]**
[役職/肩書]

- .NET開発者および愛好家
- [専門分野]
- [連絡先/ソーシャルメディア]

---

<!-- Speaker Notes: 30秒
本日のカバー内容について、皆さんに全体像をお伝えするための簡単な目次です。
-->

# アジェンダ

1. **イベント概要** - .NET Conf 2025 ハイライト
2. **.NET 10** - 長期サポートリリース
3. **Visual Studio 2026** - モダン開発体験
4. **Aspire 13** - .NETを超えたクラウドネイティブ
5. **GitHub Copilot** - AI駆動型開発
6. **Microsoft Agent Framework** - AIエージェントの構築
7. **コミュニティと今後の展望**

---

<!-- _class: section-break -->

# イベント概要
## .NET Conf 2025

---

<!-- Speaker Notes: 1分
.NET Conf 2025は大成功を収め、このコミュニティ主導イベントの15周年を祝いました。規模と到達範囲は年々成長し続けています。
-->

# .NET Conf 2025: 数字で見る

<div class="columns">

<div>

## イベント詳細
- **日程:** 2025年11月12日〜14日
- **形式:** バーチャル & グローバル
- **記念年:** 15周年 🎉
- **ライブ視聴者:** 10万人以上

</div>

<div>

## カンファレンス構成
- **1日目:** 基調講演 & 主要ローンチ
- **2日目:** 技術的な深掘り
- **3日目:** コミュニティショーケース

</div>

</div>

---

<!-- Speaker Notes: 45秒
.NET Confのグローバルな到達範囲は、活気に満ちた世界的なコミュニティを示しています。地域イベントにより、開発者はバーチャルカンファレンスの後、対面で交流できます。
-->

# グローバルコミュニティの影響

### .NET Confが重要な理由

- **オープンソース第一** - すべてのコンテンツが無料で利用可能
- **コミュニティ主導** - 世界中からのスピーカー
- **包括的な学習** - 初心者から上級者までのトラック
- **地域イベント** - 世界中で100以上のコミュニティ主催イベント
- **無料アクセス** - 登録料なし、誰でも利用可能

> 「.NETコミュニティは、世界で最も歓迎的で革新的な開発者エコシステムの1つです。」

---

<!-- _class: section-break -->

# .NET 10
## 長期サポートリリース

---

<!-- Speaker Notes: 2分
.NET 10はメインイベントです - 3年間サポートされる長期サポートリリース。これは企業が待ち望んでいたリリースです。
-->

# .NET 10: フラッグシップリリース

### 長期サポート(LTS) - 3年間のサポート

<div class="columns">

<div>

## 主な利点
- **パフォーマンス** - これまで以上に高速
- **セキュリティ** - 強化された保護
- **安定性** - エンタープライズ対応
- **互換性** - スムーズなアップグレード

</div>

<div>

## リリーススケジュール
- **リリース日:** 2025年11月11日
- **サポート終了:** 2028年
- **推奨用途:** 本番環境ワークロード
- **移行パス:** .NET 6/8から明確

</div>

</div>

---

<!-- Speaker Notes: 1.5分
パフォーマンスの改善は全体的に顕著です - ランタイム、ライブラリ、コンパイル。
-->

# .NET 10: パフォーマンスの改善

### ベンチマークが劇的な向上を示す

```csharp
// 例: 改善されたLINQパフォーマンス
var numbers = Enumerable.Range(1, 1000);

// .NET 10の最適化 - 最大40%高速化
var result = numbers
    .Where(n => n % 2 == 0)
    .Select(n => n * n)
    .ToArray();
```

**ハイライト:**
- **JITコンパイラ:** 15-20%高速なコンパイル
- **GC(ガベージコレクション):** 停止時間の削減
- **LINQ:** 最大40%のパフォーマンス向上
- **JSONシリアライゼーション:** System.Text.Jsonで30%高速化
- **ネットワーキング:** HTTP/3の最適化

---

<!-- Speaker Notes: 1.5分
セキュリティは.NET 10において最重要であり、強化された暗号化と保護メカニズムを備えています。
-->

# .NET 10: セキュリティの強化

### エンタープライズグレードの保護

<div class="columns">

<div>

## 新しいセキュリティ機能
- 強化された暗号化API
- 改善された証明書検証
- より強力なデフォルト設定
- セキュリティ脆弱性スキャン
- サプライチェーンセキュリティ

</div>

<div>

## デフォルトでセキュア
```csharp
// 新しいセキュアなデフォルト
var builder = WebApplication
    .CreateBuilder(args);

// 次の設定が自動構成:
// - HTTPS強制
// - HSTS有効化
// - セキュリティヘッダー
// - レート制限
```

</div>

</div>

---

<!-- Speaker Notes: 1.5分
主要なフレームワークの更新により、.NET 10はすべてのアプリケーションタイプで包括的になります。
-->

# .NET 10: フレームワークの更新

### すべてのプラットフォームでのモダン開発

**ASP.NET Core**
- Razor PagesとBlazorのパフォーマンス改善
- 強化されたMinimal API
- 組み込みレート制限の改善
- 向上したSignalRスケーラビリティ

**.NET MAUI (マルチプラットフォームアプリUI)**
- デスクトップとモバイルの改善
- すべてのプラットフォームでのパフォーマンス向上
- 強化されたコントロールとレイアウト
- 改善されたホットリロード体験

**Windows Forms**
- 高DPIの改善
- モダンなコントロール更新
- アクセシビリティの強化

---

<!-- _class: section-break -->

# Visual Studio 2026
## モダン開発体験

---

<!-- Speaker Notes: 1.5分
Visual Studio 2026は、Fluentデザインを使用した完全なUI刷新による大きな飛躍を表しています。
-->

# Visual Studio 2026: 再構築

### FluentUIベースのモダンインターフェース

<div class="columns">

<div>

## 新機能
- **モダンUI** - 完全なFluent再設計
- **パフォーマンス** - 高速な起動と応答
- **アクセシビリティ** - WCAG 2.2準拠
- **カスタマイズ** - 柔軟なレイアウト
- **ダークモード** - 強化されたテーマ

</div>

<div>

## 主な改善点
- 50%高速なソリューション読み込み
- 改善された検索機能
- より良いGit統合
- 強化されたデバッグビュー
- 合理化された設定

</div>

</div>

---

<!-- Speaker Notes: 1分
開発者の生産性機能は、VS 2026の中核です。
-->

# Visual Studio 2026: 開発者の生産性

### より速く作業し、よりスマートにコーディング

**ホットリロードの強化**
- より多くのシナリオのサポート
- より高速なリロード時間
- より良いエラーメッセージ
- .NET MAUI、Blazor、ASP.NET Coreで動作

**Razor編集の改善**
- IntelliSenseの改善
- より良いシンタックスハイライト
- コンポーネントナビゲーション
- リアルタイム検証

**強化された診断**
- パフォーマンスプロファイラの更新
- メモリリーク検出
- CPU使用率の洞察
- データベースクエリの最適化

---

<!-- Speaker Notes: 1分
GitHub Copilot統合は、VS 2026に深く組み込まれています。
-->

# Visual Studio 2026: AI駆動型コーディング

### GitHub Copilot統合

```csharp
// コンテキスト内のCopilot提案
public class OrderService
{
    // コメントを入力: "税込み注文合計を計算するメソッド"
    // Copilotの提案:
    public decimal CalculateOrderTotal(Order order, decimal taxRate)
    {
        var subtotal = order.Items.Sum(i => i.Price * i.Quantity);
        var tax = subtotal * taxRate;
        return subtotal + tax;
    }
}
```

**機能:**
- インテリジェントなコード補完
- テスト生成(パブリックプレビュー)
- コード説明とドキュメント
- リファクタリング提案

---

<!-- _class: section-break -->

# Aspire 13
## .NETを超えたクラウドネイティブ

---

<!-- Speaker Notes: 1.5分
Aspire 13はゲームチェンジャーです - もはや.NETだけでなく、クラウドネイティブエコシステム全体をサポートします。
-->

# Aspire 13: .NETを超えて

### すべての人のためのクラウドネイティブアプリケーション開発

<div class="columns">

<div>

## Aspireとは?
**回復力があり**、**観測可能で**、**構成可能な**クラウドネイティブアプリケーションを構築するための、意見のあるスタック。

現在サポート:
- Node.js
- Python
- Java/Spring Boot
- Go
- その他多数!

</div>

<div>

## 中核となる原則
- **コードファースト** - Infrastructure as Code
- **モジュラー** - 必要なものを選択
- **拡張可能** - カスタム統合
- **柔軟なデプロイ** - あらゆるクラウド、あらゆるコンテナ

</div>

</div>

---

<!-- Speaker Notes: 1.5分
開発者体験は合理化され、直感的です。
-->

# Aspire 13: 開発者体験

### コードファーストのクラウドネイティブ開発

```csharp
// Aspireアプリホスト - スタック全体をオーケストレート
var builder = DistributedApplication.CreateBuilder(args);

// .NET API
var api = builder.AddProject<Projects.MyApi>("api");

// Node.jsフロントエンド
var frontend = builder.AddNpmApp("frontend", "../Frontend")
    .WithReference(api)
    .WithHttpEndpoint(port: 3000);

// PostgreSQLデータベース
var db = builder.AddPostgres("postgres")
    .AddDatabase("mydb");

// Python MLサービス
var mlService = builder.AddPythonApp("ml-service", "../MLService")
    .WithReference(db);

builder.Build().Run();
```

---

<!-- Speaker Notes: 1分
デプロイの柔軟性が鍵です - Aspireはどこでも動作します。
-->

# Aspire 13: 柔軟なデプロイメント

### どこにでもデプロイ

**デプロイメントターゲット:**
- **Azure Container Apps** - フルマネージド
- **Kubernetes** - 完全なコントロール
- **Docker Compose** - ローカル開発
- **AWS ECS/Fargate** - Amazonクラウド
- **Google Cloud Run** - Googleクラウド

**組み込み機能:**
- サービスディスカバリ
- 構成管理
- 可観測性(ログ、メトリクス、トレース)
- ヘルスチェック
- レジリエンスパターン(リトライ、サーキットブレーカー)

---

<!-- _class: section-break -->

# GitHub Copilot
## AI駆動型開発

---

<!-- Speaker Notes: 1.5分
GitHub Copilotは、コード補完から包括的な開発アシスタントへと進化しました。
-->

# GitHub Copilot: ワークフローの変革

### AI駆動型開発アシスタント

<div class="columns">

<div>

## アプリケーションモダナイゼーション
- **AI駆動型.NETアップグレード**
- 自動コード移行
- フレームワークバージョン更新
- 依存関係の解決
- 破壊的変更の修正

</div>

<div>

## テスト生成
- **パブリックプレビュー**
- ユニットテスト作成
- テストカバレッジ分析
- エッジケースの特定
- モックオブジェクト生成

</div>

</div>

**新機能:**
- コード評価とレビュー
- テスト失敗の診断と修正
- パフォーマンス最適化の提案
- セキュリティ脆弱性の検出

---

<!-- Speaker Notes: 1.5分
Copilotができることの実用的な例を見てみましょう。
-->

# GitHub Copilot: 実用例

### 実際の開発シナリオ

**アプリケーションモダナイゼーションの例:**
```csharp
// Copilotは.NET Frameworkから.NET 10へのアップグレードが可能
// 古い.NET Frameworkコード
using System.Web.Mvc;
public class HomeController : Controller { }

// Copilotが.NET 10への移行を提案:
using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller { }
// + ルーティング、DI、構成の更新
```

**ユニットテスト生成:**
```csharp
// メソッドを選択 → Copilotがテストを生成
public decimal CalculateDiscount(decimal price, int quantity)
    => quantity > 10 ? price * 0.9m : price;

// 生成されたテストは次をカバー: 通常ケース、一括割引、エッジケース
```

---

<!-- Speaker Notes: 1分
Copilotはコード品質を維持し、早期に問題を検出するのに役立ちます。
-->

# GitHub Copilot: 品質アシスタンス

### テスト失敗の修正とコード評価

**テスト失敗の修復:**
- 失敗したテストを分析
- 説明付きの修正を提案
- 根本原因を特定
- リグレッションを防止

**コード評価機能:**
- ベストプラクティスの推奨
- コードスメルの検出
- アーキテクチャの提案
- パフォーマンスアンチパターンの特定
- セキュリティ脆弱性スキャン

> 「GitHub Copilotは、24時間365日あなたとペアプログラミングしてくれるシニア開発者のようなものです。」

---

<!-- _class: section-break -->

# Microsoft Agent Framework
## .NETでのAIエージェント構築

---

<!-- Speaker Notes: 2分
Agent Frameworkはパブリックプレビュー中です - これにより開発者は自律的なAIエージェントを構築できます。
-->

# Microsoft Agent Framework for .NET

### パブリックプレビュー: 自律型AIエージェントの構築

<div class="columns">

<div>

## AIエージェントとは?
次のことができる自律型ソフトウェア:
- 自然言語を理解
- 意思決定を行う
- タスクを実行
- インタラクションから学習
- システムと統合

</div>

<div>

## フレームワーク機能
- **自然言語** - 人間のようなインタラクション
- **オープン標準** - 相互運用可能
- **拡張可能** - カスタムスキル/ツール
- **統合** - 既存システムへの接続
- **.NETネイティブ** - ファーストクラスのC#サポート

</div>

</div>

---

<!-- Speaker Notes: 1.5分
フレームワークを使用したエージェントの構築は簡単です。
-->

# 最初のエージェントを構築

### シンプルな例

```csharp
using Microsoft.Agents;
using Microsoft.Agents.Skills;

// エージェントを作成
var agent = new AgentBuilder()
    .WithName("CustomerServiceAgent")
    .WithDescription("顧客の注文をサポート")
    .AddSkill<OrderLookupSkill>()
    .AddSkill<RefundProcessingSkill>()
    .WithLanguageModel("gpt-4")
    .Build();

// 自然言語でインタラクト
var response = await agent.InvokeAsync(
    "注文番号#12345を検索して返金処理してください"
);

Console.WriteLine(response.Message);
// エージェント: "John Doeの注文#12345を見つけました。
//         $59.99の返金が処理されました。"
```

---

<!-- Speaker Notes: 1.5分
実際のユースケースは、AIエージェントの力を示しています。
-->

# Agent Framework: ユースケース

### 実際のアプリケーション

**カスタマーサービス**
- 自動サポートチャットボット
- 注文追跡と管理
- FAQアシスタンス
- エスカレーション処理

**ビジネスプロセス自動化**
- ドキュメント処理
- データ入力と検証
- ワークフローオーケストレーション
- レポート生成

**開発ツール**
- コードレビューアシスタント
- ドキュメント生成器
- バグトリアージ自動化
- DevOpsタスク自動化

---

<!-- Speaker Notes: 1分
統合機能により、エージェントはエンタープライズ利用に実用的です。
-->

# Agent Framework: 統合

### 既存システムへの接続

```csharp
// 既存システムに接続するカスタムスキルを定義
public class OrderLookupSkill : IAgentSkill
{
    [AgentFunction("IDで注文を検索")]
    public async Task<Order> LookupOrder(
        [Parameter("注文ID")] string orderId)
    {
        // 既存の注文システムに接続
        return await _orderService.GetOrderAsync(orderId);
    }

    [AgentFunction("注文の返金処理")]
    public async Task<RefundResult> ProcessRefund(
        [Parameter("注文ID")] string orderId,
        [Parameter("理由")] string reason)
    {
        // 支払いシステムと統合
        return await _paymentService.ProcessRefundAsync(orderId, reason);
    }
}
```

---

<!-- _class: section-break -->

# その他のイノベーション
## .NET Conf 2025からのさらなる情報

---

<!-- Speaker Notes: 1.5分
主要な発表以外にも、いくつかの重要なアップデートがあります。
-->

# クラウドネイティブ開発フォーカス

### モダンアプリケーションアーキテクチャ

**コンテナファースト開発**
- 最適化されたコンテナイメージ
- より小さなベースイメージ(50%削減)
- より速いコールドスタート
- より良いレイヤーキャッシング

**マイクロサービスサポート**
- サービスメッシュ統合
- 分散トレーシング
- ロードバランシングの改善
- サービスディスカバリの強化

**サーバーレスの改善**
- Azure Functions .NET 10サポート
- より速いコールドスタート
- より良いスケーリング
- 改善されたトリガーとバインディング

---

<!-- Speaker Notes: 1分
MCPサポートにより、新しい統合シナリオが可能になります。
-->

# Model Context Protocol (MCP)

### AI統合のためのオープンスタンダード

**MCPとは?**
AIシステムがデータソースやツールに安全に接続できるようにするオープンプロトコル。

**.NET開発者にとってのメリット:**
- AIにデータを公開する標準的な方法
- 複数のAIプラットフォームで動作
- 安全なコンテキスト共有
- AIエージェント向けツール統合
- オープンソースで拡張可能

**ユースケース:**
- AIをデータベースに接続
- APIをAIシステムに公開
- ビジネスロジックをAIエージェントと共有
- カスタムAIツールの作成

---

<!-- Speaker Notes: 1分
コミュニティエンゲージメントは成長を続けています。
-->

# コミュニティとエコシステム

### .NETの心

<div class="columns">

<div>

## コミュニティの成長
- **10万人以上のライブ視聴者**
- **100以上の地域イベント**
- **1000人以上のスピーカー**
- **グローバル参加**
- **オープンソースコントリビューター**

</div>

<div>

## 参加方法
- 地域の.NETミートアップに参加
- オープンソースに貢献
- .NET Confイベントに参加
- 知識を共有
- プロジェクトを構築して紹介

</div>

</div>

**リソース:**
- [dot.net](https://dot.net) - 公式サイト
- [GitHub.com/dotnet](https://github.com/dotnet) - ソースコード
- [Learn.microsoft.com](https://learn.microsoft.com) - ドキュメント
- [.NET Foundation](https://dotnetfoundation.org) - コミュニティサポート

---

<!-- Speaker Notes: 1分
これから先の展望を見てみましょう。
-->

# 今後の展望

### これからの道

**次のステップ:**
- .NET 10 SDKをダウンロード
- Visual Studio 2026プレビューを試す
- Aspire 13テンプレートを探索
- Agent Frameworkを実験
- GitHub Copilot機能を有効化

**近日公開:**
- .NET 11プレビュー(2026年)
- より多くのAI統合
- 強化されたクラウドネイティブツール
- コミュニティコントリビューション
- 地域.NET Confイベント(2026年1月15日まで)

**最新情報を入手:**
- .NETブログをフォロー
- .NET YouTubeチャンネルを購読
- コミュニティフォーラムに参加

---

<!-- Speaker Notes: 1分
カバーしたすべての内容からの主なポイント。
-->

# 重要なポイント

## .NET Conf 2025が重要な理由

1. **.NET 10 LTS** - 本番環境対応、エンタープライズ向け長期サポート
2. **AI統合** - GitHub CopilotとAgent Frameworkが開発を変革
3. **Visual Studio 2026** - モダンで高速、インテリジェントなIDE
4. **Aspire 13** - あらゆる言語のためのクラウドネイティブ開発
5. **コミュニティファースト** - オープンで包括的、グローバルに接続

### .NETエコシステムはかつてないほど強力です

---

<!-- _class: section-break -->

# デモリソース
## 自分で試してみる

---

<!-- Speaker Notes: 1分
参加者に始めるためのリソースを提供します。
-->

# 入門リソース

### 始めるために必要なすべて

**ダウンロードとインストール:**
```bash
# .NET 10 SDKをインストール
winget install Microsoft.DotNet.SDK.10

# 新しいAspireアプリを作成
dotnet new aspire-starter -o MyCloudApp
cd MyCloudApp
dotnet run
```

**学習パス:**
- Microsoft Learn: .NET 10学習パス
- Aspire 13ワークショップ
- Agent Frameworkチュートリアル
- .NET開発者向けGitHub Copilot

**サンプルコード:** [github.com/dotnet/samples](https://github.com/dotnet/samples)

---

<!-- Speaker Notes: 30秒
行動喚起で締めくくります。
-->

# .NETコミュニティに参加

### つながり、貢献する

<div class="columns">

<div>

**オンライン:**
- Twitter: @dotnet
- Discord: .NETコミュニティ
- Reddit: r/dotnet
- Stack Overflow: .netタグ

</div>

<div>

**対面:**
- 地域の.NETミートアップを探す
- 地域カンファレンスに参加
- スタディグループを開催
- イベントで講演

</div>

</div>

**貢献:**
.NETプラットフォームはオープンソースであり、あらゆる種類の貢献を歓迎します!

---

<!-- _class: title -->
<!-- _paginate: false -->

# ありがとうございました!

## ご質問はありますか?

### .NET 10で素晴らしいものを構築しましょう

**連絡先:**
[メールアドレス]
[Twitter/LinkedIn]
[ウェブサイト]

**リソース:** dot.net/conf

---

<!-- Speaker Notes: 2-3分のQ&A
聴衆の質問と議論のための時間を残します。
-->

# 追加リソース

### 詳細リンク

**ドキュメント:**
- [.NET 10リリースノート](https://github.com/dotnet/core/releases)
- [Visual Studio 2026新機能](https://learn.microsoft.com/visualstudio/releases/2026/release-notes)
- [Aspire 13ドキュメント](https://learn.microsoft.com/dotnet/aspire)
- [Microsoft Agent Frameworkドキュメント](https://learn.microsoft.com/agents)

**動画:**
- .NET Conf 2025録画
- Channel 9: .NETシリーズ
- Visual Studio Toolbox

**コミュニティ:**
- .NET Foundationプロジェクト
- Awesome .NET - 厳選されたリソース

---

<!-- _paginate: false -->
<!-- _class: title -->

# 付録
## 詳細のための追加スライド

---

# 補足: .NET 10パフォーマンス詳細

### 詳細なベンチマーク比較

| シナリオ | .NET 8 | .NET 10 | 改善 |
|----------|--------|---------|-------------|
| JSONシリアライゼーション | 100ms | 70ms | 30% |
| LINQクエリ | 150ms | 90ms | 40% |
| HTTPリクエスト | 50ms | 40ms | 20% |
| 起動時間 | 800ms | 600ms | 25% |

**メモリ使用量:**
- 平均ヒープサイズが15%削減
- GCコレクションが30%高速化
- 改善されたメモリ割り当てパターン

---

# 補足: 移行ガイド

### .NET 10へのアップグレード

**.NET 6/8から:**
```bash
# global.jsonを更新
{
  "sdk": {
    "version": "10.0.0"
  }
}

# プロジェクトファイルを更新
<TargetFramework>net10.0</TargetFramework>

# アップグレードアシスタントを使用
dotnet tool install -g upgrade-assistant
dotnet upgrade-assistant upgrade MyProject.csproj
```

**破壊的変更:** 最小限 - 主にAPI改善
**推奨アプローチ:** 徹底的にテストし、重要度の低いアプリから先にアップグレード

---
