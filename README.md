# ByBine

> 細菌の増える様子をシミュレートした
> 
> 細菌の死ぬ確率と最初の数を設定できるようにしてある

## 細菌が死ぬ仕組み

> Assets/Script/Bacteria.csの23~28行目
>
> 各個体について細菌が分裂するタイミングと同時に一定確率で死ぬアクションを書いた。
>
> 各個体について一定確率で死ぬようなコードだがこれは全体として一定確率で死ぬのと同じことである。
>
> 期待値を使って下で説明する。

## 説明

> 個体数を<img src="https://latex.codecogs.com/gif.latex?n" />死ぬ確率を<img src="https://latex.codecogs.com/gif.latex?p" />とすると
>
> k=1,2,...nに対して確率変数
>
> Markdownでは数式が書きにくいので他で書きます。

## Simulation

`./Application`から環境に合ったものを実行してください。
