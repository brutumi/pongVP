# Понг - Визуелно
###### Изработен од: *Јован Јакимовски (163088), Бојан Јакимовски (163142)*

## 1. Опис на Апликацијата:
Апликацијата која ја избраме е Понг видео играта која е една од првите аркадни видео игри, и претставува пинг-понг со 2D графика.

Нашата имплементација на играта e различна, така што ние додадовме со секој нов погодок да се појавува ново топче во играта.

## 2. Упатство за користење
Играта се игра од двајца играчи на иста тастатура

#### *Контроли*

```       
        Играч 1		  Играч 2
	Горе – W	  Горе – Стрелка нагоре
	Доле – S	  Доле – Стрелка надоле
```
Резултатот e видлив на екранот, играта завршува кога некој од играчите ќе направи 50 поени.
## 3. Решение
### 3.1 Дизајн и имплементација
Формата е со фиксна големина, и опциите за зголемување се исклучени за да нема неправилности во играта ако се зголеми работната површина
### 3.2 Класи
Имаме 3 класи:

`Player` класата го чува резултатот за играчот, палката како PictureBox, брзината и неколку помошни променливи.

#### Метод DoMove
```
private void DoMove(bool? goingUp) {
            if(goingUp.HasValue) {
                var speed = (int)Math.Round(movementSpeed * ((float)numberOfTicksGoingInTheSameDirection / 10));
                if(goingUp.Value) {
                    speed *= -1;
                }

                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                        Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
                        , paddle.Location.Y + speed)
                        )
                    );
            }
        }
```
#####Ограничување на палките, за да не се движат надвор од прозорецот.

Го ограничуваме од доле така што ја споредува локацијата на долниот крај на формата : `PongWorldInfo.bottomOfWorld` , со новата локација : `paddle.Location.Y + speed` , и го бара минимумот од нив така што ако пробаме да одиме подоле нема да дозволи и ќе ја одбере крајната локација на формата : `PongWorldInfo.bottomOfWorld`, потоа ограничување од горната страна со треба да ја споредуваме најгорната позиција на формата : `PongWorldInfo.topOfWorld`чија вредност и 0, со новата позиција (која веќе е проверена и ограничена од доле) : `Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
, paddle.Location.Y + speed)`


```
            paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                        Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
                        , paddle.Location.Y + speed)
                        )
                    );
```
