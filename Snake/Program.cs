using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.SetBufferSize( 80, 25 );

			Walls walls = new Walls( 80, 25 );
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point( 4, 5, '*' );
			Snake snake = new Snake( p, 4, Direction.RIGHT );
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if ( walls.IsHit(snake) || snake.IsHitTail() )
				{
					break;
				}
				if(snake.Eat( food ) )
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep( 100 );
				if ( Console.KeyAvailable )
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}
			WriteGameOver();
			Console.ReadLine();
      }


		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition( xOffset, yOffset++ );
			WriteText( "============================", xOffset, yOffset++ );
			WriteText( "И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++ );
			yOffset++;
			WriteText( "============================", xOffset, yOffset++ );
		}

		static void WriteText( String text, int xOffset, int yOffset )
		{
			Console.SetCursorPosition( xOffset, yOffset );
			Console.WriteLine( text );
		}

	}
}
//              List<int> numList = new List <int>();
//              numList.Add(0);
//              numList.Add(1);
//              numList.Add(2);
            
//             int x = numList [0];
//             int y = numList [1];
//             int z = numList [2];
            
//             foreach (int i in numList){
//                 Console.WriteLine (i);
//             }
//               numList = RemoveAt[0];
              
//               List<char> charList = new List<char>();
//               charList.Add('*');
//               charList.Add('#');
//               charList.Add('@');
//               charList.Add('$');
              
//               foreach (char r in charList) {
//                   Console.WriteLine (r);
//               }
              
//              Point p1 = new Point(1, 3, '*');
//              Point p2 = new Point(4, 5, '#');
//              Point p3 = new Point(6, 1, '@');
//              Point p4 = new Point(7, 2, '$');
             
//              List<Point> pList = new List<Point>();
//              pList.Add(p1);
//              pList.Add(p2);
//              pList.Add(p3);
//              pList.Add(p4);
              
//               foreach (Point p in pList){
//                   p.Draw();
//               }
              
//               Console.RedLine();
//           }
//       }
//  }
            
//             Console.RedLine();
//         }
//     }
}
