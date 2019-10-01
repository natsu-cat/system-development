# System Development
System Developmentのリポジトリ.

### Gitの運用方法について

issue毎に `feature-XXXX` ブランチを切って `develop` ブランチにPRを送る.  
PRはレビュー後 `develop` にマージされ, その後適切なタイミングで `master` にマージされる.

### セットアップ(Forkした後に最初にすること)

- 初回設定
事前にbashでローカルの作業するディレクトリに移動しておく.

```bash
$ git clone 各自Forkしたsystem-developmentのリポジトリのurl # わからなかったらgit cloneで調べて
$ git remote add upstream git@github.com:2D-4/system-development.git # 上流のリポジトリを登録
```
ちなみに設定は、
```bash
$ git config --list
```
で確認できる.

- idとemail設定してない人向け

```bash
$ git config --global user.name <id> # <id>にGitHubのusername
$ git config --global user.email <mail> # <mail>にメールアドレス
```

### 作業の流れ

For Example

`#53 データベースとの通信を確立する`というissueを割り当てられたとする.

```bash
$ git checkout -b feature-53 # checkout でブランチの切り替えができ、 -b のオプションでブランチの作成も同時にできる
                             # 今回は#53なのでfeature-53でブランチを切った
$ git branch # どのブランチにいるか確認でき、 -a オプションでリモートのブランチも確認できる
```

- 作業終了時

```bash
$ git add ファイル名 # ファイル名の代わりに -A と入力すると変更済が全てステージングされる
$ git status # 変更箇所が確認できる

$ git commit -m '#53 データベースとの通信を確立' # ''内にコミットメッセージを入力
$ git push -u origin feature-53 # ブランチをリモートに登録
```

その後は上記の `Gitの運用方法について`参照.

### リモートの変更を取り込む

自分の変更を取り込む前に、他人の変更が入る場合があり、その時は上流の変更を取り込む必要がある.
Slackの #notice にMergeの通知が来たらしようね。

```bash
$ git branch develop # 作業中のブランチからdevelopに切り替え
# ここからやり方が２通りある
# やり方①
$ git fetch upstream # 上流リポジトリの変更を自分のローカルに取り込む
$ git merge upstream/develop # ローカルのdevelopに他人の変更を追加

# やり方②
$ git pull upstream develop #こっちの方が一般的かもしれない

# pullコマンドはfetchコマンドとmergeコマンドをどっちも行なっている
# つまり、ブランチの情報だけ取得したい(mergeしたくない)時はやり方①を使う

# そして最後に
$ git push origin develop # 自分のリモートリポジトリにも変更を追加
```

わからない箇所がある場合、`自分で記事を調べる`こと
