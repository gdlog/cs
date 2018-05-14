
        //ハローワールドをコンソールに表示
        Debug.Log("Start");

        //変数を表示
        int age;
        age = 30;
        Debug.Log(age);

        //変数に変数を代入する
        float height1 = 169.5f;
        float height2;
        height2 = height1;
        Debug.Log(height1);
        Debug.Log(height2);

        //文字列を扱う
        string name;
        name = "kitamura";
        Debug.Log(name);

        //数値の計算
        int answer;
        answer = 2 + 1;
        Debug.Log(answer);
        //困ったらデバッグログで出力

        */
        /*
        int hp = 120;
        if (hp > 100)
        {
            Debug.Log("逃げる!");
        }
        else if (hp == 100) {
            Debug.Log("attack !");
        }
        else
        {
            Debug.Log("defense /");
        }
        */
        /*
        int x = 1;
        if (x == 1) {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        Debug.Log(y);
        */
        /*
        int sum = 0;
        for (int i=1; i<=20; i++) {
            sum += i;
        }
        Debug.Log(sum); //210
        */


        int[] array = {83,99,52,93,15};

        for (int i = 0; i <= array.Length; i++)
        {
            if (array[i] >= 90)
            {
                Debug.Log(array[i]);
            }
        }
