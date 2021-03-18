using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//鏈式存儲
namespace _001_線性表
{
    class LinkList<T> : IListDS<T>
    {
        //存儲一個頭節點
        private Node<T> head;
        //提供一個構造方法
        public LinkList()//來進行構造
        {
            head = null;//置空
        }

        //依次實現方法
        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public void Add(T item) //添加一個T類型的數據，根據這個數據來創建一個節點
        {
            Node<T> newNode = new Node<T>(item); //根據新的數據創建一個新的節點
            //如果頭節點為空，那麼這個新的節點為頭節點
            if (head == null)
            {
                head = newNode;
            }
            else
            {//把新來的節點放到 鏈表的尾部
                //要訪問到鏈表的尾結點
                Node<T> temp = head; //先定義一個臨時結點 替代頭節點
                while(true) //死循環
                {
                    if(temp.Next !=null) //Next--當前節點的下一個節點 如果下一個節點不等於空的話 !=不等於
                    {
                        temp = temp.Next; //取下一個節點 讓下一個節點複製給temp
                    }//這樣的話會在某一次會滿足else的情況
                    else //else的情況就是當Next等於空的時候 就是他下一個節點沒有了 也就是temp就是我們的尾節點
                    {
                        break;
                    }//這樣的話當經過這個死循環之後 temp裡面存儲的就是我們的尾節點
                }
                temp.Next = newNode; //在這裡我們讓尾節點指向新節點就可以了

            }
        }

         public void Insert(T item, int index)
        {
            //根據新來的item創建一個新的節點
            Node<T> newNode = new Node<T>(item);

            //首先head不能為空 也就是插入是會有數據的
            if (index == 0)//第一種狀況：插入到頭節點
            {
                //當我們要往鏈的位置插入 新節點就是head了 
                newNode.Next = head;
                head = newNode; //新節點就是頭節點了
            }
            else //另一種情況：假設往某個中間點插入的話 要去修改上一個節點的Next 還有當前位置的Next
            //相當於要去修改索引只想新節點 還有去修改此索引指向下一個節點
            //因此首先要去訪問到當前的原 前節點 和 後節點
            {
                Node<T> temp = head;//首先聲明一個節點指向頭節點
                for (int i = 1; i <= index-1; i++) //接著讓這個頭節點向後運動 每運動一次相當於索引 
                                                //那我們想取得索引為index的節點 只需要讓temp向後移動index次就好
                {
                    //讓temp向後移動一個位置
                    temp = temp.Next; //讓temp向後移動一個位置
                }
                Node<T> preNode = head;
                Node<T> currentNode = temp.Next;
                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }

        

        public T Delete(int index) //兩種情況：一種是刪除頭節點 一種是刪除中間某個節點
        {
            T data = default(T);
            if (index==0)//刪除頭節點
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;//首先聲明一個節點指向頭節點
                for (int i = 1; i <= index - 1; i++) //接著讓這個頭節點向後運動 每運動一次相當於索引 
                                                     //那我們想取得索引為index的節點 只需要讓temp向後移動index次就好
                {
                    //讓temp向後移動一個位置
                    temp = temp.Next; //讓temp向後移動一個位置
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;
            }
            return data;
        }

        public int GetLength()
        {
            //突如情況
            if (head == null) return 0; //當head為空的時候 應該是0

            Node<T> temp = head;//從頭開始編譯
            int count = 1; //表示節點的數量 當前結點是1
            while(true)
            {
                if(temp.Next != null) //如果temp.Next(下一個節點) 不等於空 說明他有下一個節點
                {
                    count++; //有下一個節點的話
                    temp = temp.Next; //temp 等於下一個節點
                }
                else //else的情況 就是當他沒有下一個節點的時候
                {
                    break; //直接break
                }
            }
            return count;
        }
        public void Clear()//清空
        {
            head = null; //讓頭節點=空
        }
        public bool IsEmpty()//判斷是否等於空
        {
            return head == null; //判斷頭節點是否等於空
        }

        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 1; i <= index; i++) 
                {
                    //讓temp向後移動一個位置
                    temp = temp.Next; //讓temp向後移動一個位置
                }
                //i<=index 因為比如說index=0的時候 這個編譯走的時候會運行0次 因為i=1 i<=0的條件 所以她直接會返回head
                //當index=1的時候 運行一次 相當於讓這個結點(temp)走一次 想這樣走一次相當於他找到下一個節點

                return temp.Data;
            }  
        }
        public T GetElem(int index)
        {
            return this[index]; //透過上面的索引器去得到
        }
        public int Locate(T value) //定位value的所在位置
        {
            //判斷head是否等於空
            Node<T> temp = head;//定義一個臨時節點
            if(temp == null) //如果temp等於空 相當於head=空 那肯定是找不到的
            {
                return -1; 
            }
            else
            {
                int index = 0; //定義一個索引 最一開始的index從0 最一開始判斷temp就是head裡面的值是否相等
                while (true) //使用一個死循環來做判斷
                {
                    if (temp.Data.Equals(value)) //說明相等
                    {
                        return index; //說明找到數據
                    }
                    else //沒有找到數據 說明temp裡面的值不是我們要找的值
                    {
                        if(temp.Next != null) //不等於空
                        {
                            temp = temp.Next; //所以我們要讓temp這個節點一直向下走 向下走之後再做判斷
                        }
                        else //下一個節點為空=沒有下一個節點了
                        {
                            break;//直接跳入循環 說明沒有滿足if的情況 說明沒有找到value所在的節點
                        }
                    }
                }
                //那就是沒有找到
                return -1;
            }
        }
    }
}
