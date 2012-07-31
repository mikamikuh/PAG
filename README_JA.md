PAG

========

PAGはPrefabAccessorGeneratorの略です。
eclipseの[EMF](http://www.eclipse.org/modeling/emf/)やXCodeの[CoreData](https://developer.apple.com/cocoa/coredatatutorial/index.html)のようなデータモデリングツールをUnity3D上で実装する為の1機能です。
PAGは指定された引数からPrefabに設定されているコンポーネント(主にScript)にEditorからアクセスする為のコードを自動生成します。

 * AccessorManager : 生成された全てのアクセサを管理するクラス
 * DataAccessor : 1つのPrefabに対応するデータにアクセスする為のクラス
 * DataScript : Prefabに追加するScript群