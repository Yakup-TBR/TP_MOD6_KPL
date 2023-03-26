// See https://aka.ms/new-console-template for more information
using tpmodul6_1302210113;


        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - [Yakup Asmaidy Atanggae_PRAKTIKAN]");

        //test prekondisi
        //video = new SayaTubeVideo(null);
        //video = new SayaTubeVideo("Judul video dengan panjang lebih dari 100 karakter akan menghasilkan ContractException");

        for (int i = 0; i < 1000000000; i += 10000000)
        {
            video.IncreasePlayCount(10000000);
        }
        video.PrintVideoDetails();
