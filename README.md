# System Development
System Developmentのリポジトリ.

### Gitの運用方法について

issue毎に `feature-XXXX` ブランチを切って `develop` ブランチにPRを送る.  
PRはレビュー後 `develop` にマージされ, その後適切なタイミングで `master` にマージされる.

### 初期設定

### セットアップ(Forkした後に最初にすること)

- 初回設定
事前にbashでローカルの作業する場所に移動しておく

```bash
$ git clone @各自Forkしたsystem-developmentのリポジトリのurl // わからなかったらgit cloneで調べて
```

- こっちは設定してない人向け

```bash
$ git config --global user.name <id> // <id>にGitHubのusername
$ git config --global user.email <mail> // <mail>にメールアドレス
```

### 作業の流れ

- For Example

`\#53 データベースとの通信を確立する`というissueを割り当てられたとする

```bash
$ git checkout -b feature-53 // checkout でブランチの切り替えができ、 -b のオプションでブランチの作成も同時にできる
                             // 今回は#53なのでfeature-53でブランチを切った
$ git branch //どのブランチにいるか確認でき、 -a オプションでリモートのブランチも確認できる
```

- 作業終了時

```bash
$ git add ファイル名 // ファイル名をステージングする。ファイル名の代わりに -A と入力すると変更済が全てステージングされる
$ git status // 変更箇所が確認できる

$ git commit -m '#53 データベースとの通信を確立' //''内にコミットメッセージを入力
$ git push -u origin feature-53 //ブランチをリモートに登録
```

その後は上記の `Gitの運用方法`参照

### リモートの変更を取り込む

自分の変更を取り込む前に、他人の変更が入る場合があ理、その時はリモートの変更を取り込む必要がある。

```bash
$ git fetch // リモートの変更をローカルに取り込む
$ git rebase origin develop
```

わからない箇所がある場合、`自分で記事を調べる`こと
