-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 05, 2025 at 11:50 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aero_quest`
--

-- --------------------------------------------------------

--
-- Table structure for table `aircrafts`
--

CREATE TABLE `aircrafts` (
  `aircraft_id` int(11) NOT NULL,
  `model` varchar(255) NOT NULL,
  `manufacturer` varchar(255) NOT NULL,
  `totalSeat` int(11) NOT NULL,
  `availableSeat` blob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `aircrafts`
--

INSERT INTO `aircrafts` (`aircraft_id`, `model`, `manufacturer`, `totalSeat`, `availableSeat`) VALUES
(1, 'Boeing 737', 'Boeing', 180, 0x41332c41342c41352c41362c41372c41382c41392c4131302c4131312c4131322c4231332c4231342c4231352c4231362c4231372c4231382c4231392c4232302c4232312c4232322c4232332c4232342c4332352c4332362c4332372c4332382c4332392c4333302c4333312c4333322c4333332c4333342c4333352c4333362c4433372c4433382c4433392c4434302c4434312c4434322c4434332c4434342c4434352c4434362c4434372c4434382c4534392c4535302c4535312c4535322c4535332c4535342c4535352c4535362c4535372c4535382c4535392c4536302c4636312c4636322c4636332c4636342c4636352c4636362c4636372c4636382c4636392c4637302c4637312c4637322c4737332c4737342c4737352c4737362c4737372c4737382c4737392c4738302c4738312c4738322c4738332c4738342c4838352c4838362c4838372c4838382c4838392c4839302c4839312c4839322c4839332c4839342c4839352c4839362c4939372c4939382c4939392c493130302c493130312c493130322c493130332c493130342c493130352c493130362c493130372c493130382c4a3130392c4a3131302c4a3131312c4a3131322c4a3131332c4a3131342c4a3131352c4a3131362c4a3131372c4a3131382c4a3131392c4a3132302c4b3132312c4b3132322c4b3132332c4b3132342c4b3132352c4b3132362c4b3132372c4b3132382c4b3132392c4b3133302c4b3133312c4b3133322c4c3133332c4c3133342c4c3133352c4c3133362c4c3133372c4c3133382c4c3133392c4c3134302c4c3134312c4c3134322c4c3134332c4c3134342c4d3134352c4d3134362c4d3134372c4d3134382c4d3134392c4d3135302c4d3135312c4d3135322c4d3135332c4d3135342c4d3135352c4d3135362c4e3135372c4e3135382c4e3135392c4e3136302c4e3136312c4e3136322c4e3136332c4e3136342c4e3136352c4e3136362c4e3136372c4e3136382c4f3136392c4f3137302c4f3137312c4f3137322c4f3137332c4f3137342c4f3137352c4f3137362c4f3137372c4f3137382c4f3137392c4f313830);

-- --------------------------------------------------------

--
-- Table structure for table `flights`
--

CREATE TABLE `flights` (
  `id` int(11) NOT NULL,
  `fromX` varchar(255) NOT NULL,
  `toX` varchar(255) NOT NULL,
  `departure` varchar(255) NOT NULL,
  `arrival` varchar(255) NOT NULL,
  `aircraft_id` int(11) NOT NULL,
  `passengerCount` int(11) NOT NULL,
  `date` date NOT NULL,
  `price` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flights`
--

INSERT INTO `flights` (`id`, `fromX`, `toX`, `departure`, `arrival`, `aircraft_id`, `passengerCount`, `date`, `price`) VALUES
(1, 'New York', 'Los Angeles', '10:20 pm', '11:20 pm', 1, 150, '2024-12-11', 69),
(2, 'Manila', 'Cebu', '12:30 pm', '1:45 pm', 1, 180, '2024-12-12', 3000),
(3, 'Davao', 'Clark', '9:15 am', '10:30 am', 1, 200, '2024-12-13', 4000),
(4, 'Iloilo', 'Tacloban', '2:00 pm', '3:15 pm', 1, 120, '2024-12-14', 2500),
(5, 'Clark', 'Zamboanga', '8:45 am', '10:00 am', 1, 100, '2024-12-15', 5000),
(6, 'Puerto Princesa', 'Manila', '7:30 pm', '9:00 pm', 1, 130, '2024-12-16', 6000),
(7, 'Cebu', 'Davao', '6:20 am', '7:35 am', 1, 90, '2024-12-17', 3500),
(8, 'Bacolod', 'Cagayan de Oro', '1:00 pm', '2:30 pm', 1, 110, '2024-12-18', 4500),
(9, 'Manila', 'Clark', '10:50 am', '12:10 pm', 1, 160, '2024-12-19', 3000),
(10, 'Davao', 'Cebu', '5:40 pm', '7:00 pm', 1, 140, '2024-12-20', 4000);

-- --------------------------------------------------------

--
-- Table structure for table `mail`
--

CREATE TABLE `mail` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `mails` blob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mail`
--

INSERT INTO `mail` (`id`, `userId`, `mails`) VALUES
(1, 1, 0x5b7b224461746554696d65223a22323032352d30342d30375431383a33383a30382e3436323138372b30383a3030222c224964223a2261326132343431322d366162382d343239652d393137362d393361646361616366393062222c2254797065223a22426f6f6b696e6720436f6e6669726d6174696f6e222c2246726f6d223a22496c6f696c6f222c22546f223a225461636c6f62616e222c22436f6465223a2259355158584855524948222c22497352656164223a66616c73652c22497344656c65746564223a66616c73652c224461746544656c65746564223a22303030312d30312d30315430303a30303a3030222c2249735065726d616e656e746c7944656c65746564223a66616c73652c224163636f756e744e756d626572223a22222c225072696365223a2232353030222c22436c617373223a222d31227d2c7b224461746554696d65223a22323032352d30342d30375431383a33383a34332e353139363337372b30383a3030222c224964223a2265353863336439332d303265342d343365642d383236662d313963373264663866623235222c2254797065223a22436865636b20696e222c2246726f6d223a22496c6f696c6f222c22546f223a225461636c6f62616e222c22436f6465223a224132222c22497352656164223a66616c73652c22497344656c65746564223a747275652c224461746544656c65746564223a22323032352d30342d30375431383a33383a35312e323738373437382b30383a3030222c2249735065726d616e656e746c7944656c65746564223a66616c73652c224163636f756e744e756d626572223a6e756c6c2c225072696365223a6e756c6c2c22436c617373223a6e756c6c7d5d);

-- --------------------------------------------------------

--
-- Table structure for table `profiles`
--

CREATE TABLE `profiles` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `birth` date DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `phone` varchar(255) DEFAULT NULL,
  `profile` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `profiles`
--

INSERT INTO `profiles` (`id`, `userId`, `name`, `birth`, `age`, `gender`, `email`, `phone`, `profile`) VALUES
(1, 1, 'Nathaniel Comia Segovia', '1753-01-01', 23, '', '123@gmail.com', '123123', 0x89504e470d0a1a0a0000000d494844520000012c0000012c0806000000797d8e750000000467414d410000b18f0bfc6105000000097048597300000b1300000b1301009a9c180000130c49444154785eed9d3d8c5dc51580a9a00952144b44d0e0ca95232290a250e18a8a08c42a055224a868a18a4485e4b42bb9c2ed769153216d41031215ad2982e24504d9fbfc6c923cd8f7eccd867272cedb79f6eef3793ff7de997be7e7fba44fcb8fbdde3b6fcef19973e7ce7d0a000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006030be71eee983897bf6ce897b7efcd05d1a1dbbcb8733f7caeda9bba28e66ee75f9ef6fa8f71eb877d6b9f875eae2f7ebf7d2ef29ff7c51ff8c5b0fdd05fd33fd1f0f00701e4d109a2824915c5a24a3bb33b723fffeae7c7d7f08f5cfd6c4a609d1ff4cf384463203a8080d780d7c5fd55cd1cac74a1889bbb3486424318082d0e59c564e1927a76dddb97bec5efb5eaef53fcefdc25f3e00a48c561b9aa0ee3c74af169ea0d63ad26b9704a64b492a308084d02a4a9778daf3b18217e73db137748ca8be0006407b37f74edccb3557511ddcd10a94e40510115dda6892a2920aea0e7d2f80402ceeea91a4e2ab63acc9cb0f3d006ccb996a6ab0bd50b5ba68d85375016c806a2a312571e967e23f1e0050f4f63b892a5db5ea62b90855a3cb3e0d82f912c408124c4f12175489df37457f2a53495c500554546549e28222a1995eb6242e288207cefd8a44558f7a8a04db21203bb4a12e89ea556b5263f98effe77e4fe2822cd0a5010d7564990849a37fa3b2fcc36559264272b04d0137a98f5af9e902300c5455d8445d26526dc1205055611b75cee8dcf1d308202efe0e205515769313212036ba01949dea184a9d4b9c060151d0d74a59930eb1ab34e421182c01b10f758eb144844ee8a3352c01b12fb98b08ad61c73a0e217711a131f4ab7068e96bc156fc70ec5eb3261062dfea43d47e5a029c479beb77666ec79a388803ba435f0bcea11382e63aa62acd787804c90a7390a405242bcc4a9256c5f8e38bd9b68059a949ebd64377c14f63a8019215e6acce5d92562590acb004495a1540cf0a4b5293163dad4221596189d2882f109215962c49ab20485658833ac7f5690d3fed215778dc062b7287a495313cc88cd52973de4f7fc8098e88c15ae5689accd003d0ac0f12b116794d7e266893ddfa00116b928da519c01d41c4c7b2dd2171b82388785ea9b4def0e1012941931dd196a39613e3d6d45db43e28443c95374c27027d2bc4cdf2a07422e81addfa8010f1bcf4b30686be1562337949eb40b0df0ab1b9eccf1a08fa5688adddf161047dc05210b19b3c6fd8132c0511c3c85dc31e6029881846ee1a46469f40b7061e11dbc95dc348b0411431bc7ad790534a23a027295a038ec37bf893fbf0f0c87d349ebaaba3a9db3dabfe37fd7fd6efc334e459c3c0d0684f434d4c778edcf5f1ccddb83b755f49421ac9d713f9eab6517fad7c9f03f1a6fcfbbeb8abdff3ec9f81c3c8b386016129389cf3a432755fc8d791269d488efc9fb16bfd0c185f1af081a0d1debf9a38348134a99e4239afc24eab379257cfde9eba8b3eeca02d5457fda84b334912fb4324a955cacf3591af7bf4c0fa5163cd871db481ea2abe2926aa65e5e79c68d545e28a2f3be03b407515cf1c12d5b2f2736bc5b52fcb551af591649b434b785e309e7aa74f02ffc7b3c92027e51ae64bc5e5ebc230526535844da2711c9f2ea90e961340aeb24c8c23555643e85d8557abaa9c967fdb2ad746b51541aaac06505d05f6748f9319f0a5389eb9cfcd6bc75652656d09d55538750928c11c73c3676a8e5822869307a3b780ea2a8c3e5965db586fab5cfb84a41546f6656d80ea2a8cfe21e4ea92d5421983898ec1f2b8607379c6700df237e31fac41c3ed9d076a81cdf5169e90b4bacb33862be04486eeceb72d90acce7ac2f2b0bb5459069c77d5cd5a7b569b94b1a1a7d551a9b25ef5610a0ad555374956eb95319af0384f7bd9e2b004cdf66e8e4f0fc43383154f9571d28303cdf1c3cdb2c5e10c32203bcb0384db29c1a827779a418a4fb86f8d216e96e6bb87e5607bfdf6052b3071b51c0cd8529aef02cdf676fae361e85b3554c68e7e564b79be5060677b4b2b783e30963c77d84e6dbefbb0ad93d1c4bd600d0caed7df15348311b796a5610bab5e16b21c6ca7041b4bc18eca3872d7b08555efc96239d85c09b6bde5e0c3d6526535b4da6521cbc1764a90515d0552c673b23cbeb8d92a97855a5a5a8381ab9520a3ba0aec78e63eb1c61a575be5b290e5607325c0a8ae022be34a2faba1d59d93c566d1e64a70ed2e071b06935e56430f26ee591fcee5c3b3832d3c7d7dbb156cd85119df9b4f8c37aeb5aa670b4733f7ba350868ab3bb3ad40c3609eb0fbbd99e39a9e2dd45ba3d620a0ad0414cdf6d8cedc0d6becd1b69aed0d6c6768aefcedffb51964184c19679aef0dad627b83ae7dad8b475b9683bdc9b2b0a155f4b178d144332590b83bd89fdc2d6ca0f6a27d58970bfdab86722a436f4a85f585f919a069f17d2cb9c00bd685e35a0face0c2f0ea582f8d3d6eb0e8fd58b7a7eea275d1b85a2bb0309a27d66780ab9522e4920feff2908be3f9c1068e7e727f31820a237a38e395604dd498f6e15d1e34dc9b393a72d7ada0c2a8ee599f05da4ac22a7703a95c1c0df7064af0f0469cbe6503692335a67d7897855c180df7a6f2fc60efea989b9f05aeb4c8c63b0df7567287b06765cc7910baa1f77f762ffa302f87c3997bc5ba585c2b09ab7fbf353e075c63913bdea5d4be625d2cae71ea464640615c7f343f0b5ca9ac9eaef8302f07ee1036578367299830be24ac86de3f766ffb302f07ee1036578367299830be24ac86167964b275a1b85e0d9ea560c2f892b05af88d734ffb50cf1fb634b4538367299830b2da37b43e0b5c6f515b1b38b4afa534dd8790bb842d2c6a6b835458bc74a2859c343a8824ac166a8cfb70cf1ff660b5949deebdab636e7e16b8d6a2f66249f6e59486164a00f12c61ffee5b9f05ae5763dc877bfec8df5a6c1a6de198b7e5f42eafae6f67519b47d934da4ecec3eadff10377d5fa2c70bd459def4ec26a276fcce95feb73c0cdca92b09c73b1e48276962f10b7538288bd583dc91eacf616b5dbfd9e5c8c7591b885dc29ec4dde9ad35e1216cea5f1de9f34dcdb5b54c2b22e10b7933e567fea585b9f016ea70ff7fcb12e0e1bc9417ef165877b477db8e78f7571b8bd124c6c208d2f6fcbe9a80ff7fcb12e0eb7773c731f19018601e57d84ddf5e19e3fd6c5616359164652c696174f04d0877bfe581787cd94c0e26e6124b93b18461feef9635d1c36737e076bea4eac80c3f6cad84e96c71adbe9c33d7fac8bc3e64a80d17c0f2fcdf640fa70cf1f368e86912a2bac32a654578164a73b9a4aa051658593ea2a90242c34a5ca0aa38c25d555408b4a581c2f13560938ee187697ea2aa0451d2f43c28a22fbb25aaa276018e3891d2ceb3c2c8e480eaeee7e6769d85c19bb09bbdac35bd411c9bc84228e52b9fecd0a4a5c2b4bc10816f5120a5ef3154fa9b46e1a4189862c05e3a931eec33d7f24fbf222d548faf3b238467983325613cebb8aa7c6b80ff7fc91f5ed45eb22318cf4b3d62b6344df2ab2774edcf33edcf347b2ef05eb22319c1298bbcb818aa7f2eaaef8de9218f7e19e3fceb9a7ad8bc4b04a70b23feb4969b2f7e03712e33edccb40aaac77ad0bc5b072e7f09c24ab1ed4d8f6615e0e7261bc9bb02735509702b74649563d2909ab9c4da30bd83cdaafa32377bdc646bcbf6692558f16f59afa05ecc5ea5f7f167c355b1ee49a2734d8fbb7a83d580b749f8675b118d7f996873a9e3bfc96ad0bc378ff67f7a20ff372606bc3b04a40177b8ed621af981fd4a2b6349cc5ba58eccfd29688724d13b9a6dde5ebc47ef5e15d1e7271dc294c4009f6fd021af2fb3c6a33bcf78fdddb3ebccb833b85e9e81fe7f9ca4804a94baf2a218bbc43b86074ec2e5b178dc39951e2fa96e55f7a6a4cfbf02e0f1aefe97a267125d3e3d265abfe4c24aa742deaa1e765f49942ddc66f5d38a6a394f9bae9f46b2b89f4a4565337e851a5af0fed72e17cf77c9c9fb5759abca2565e5a49c9d779929a577ac6cf82e959e42339cbc845725c72a66a32d104a6fb9e34c18c8edcddb389671be7c9497e9f5fea6982daa592ca538d651fd6e5329ab817ac8bc77cd544a68967ee03b7f784f2dfef3d7057494c655974ff6a016763219661716760ad823e1662de56d1bf5ac0c90d88795be4090daba08f8598b755f4afcec27e2cc43cbdf7c0bde3c3b81eeef25c21629e96f45afa6d61598898a7451ed8b7091ed341cc531fc2f5c1f606c4bc2cfa38994dfcc02bec11b3525645977cf8d607cb42c47cd458f5a15b2fdc2d44ccc41aef0e2ec3dd42c43cac6eb3e82a581622a66d959b4557c1b385e97a78e43e1a4fddd53b47eefa68eaf6447dbfa1be75e7abb93377533cd85afffb16df47bfa7ffdebbfa67c9af317f0e1cd67b27ee651faec09133c379f893fb501392260e4d203e998cc4c1ce76979fe1447e364d7037e5dff71f2534f959cffeecd89f0713f7ac0f5750d893155f0d780dfcf1ccddf08929c797aa8ee45a1e2532aab2f856bdf76a1534dfc3abc12c81bd977172da4ab9d689785313b1568b67c700bb5be5a338dba08d3d6bc0703b7d05354f50baac5a0eec5af44b4aadc2f6a8c0ba49b37d0d34df9bebfb4ffbf2cf07678316cf39f22fcee0fd860dad7a67fb26d8f9be9d1a78a2de612b7699174b19bf895f2293bc36a8d55535e7b6b7852acbd62ff7a8a4022a633991affb2c1b57c8cef6cd50659d57024a2b01925464fd18ef9d1dfbda652bc396d45e652daa2991255fcfcaf84f46fa9afcdaab2eaaabeda97523e9a3655fc577f852527b5db5262eaaab86c8b2b09a57da8f35284e1bc166e0e0b05697b8a8ae9a53432f4b2b2a991c7abbdd0c144ccb5a1217d5554b4aed65b1f4cbdba21317d5557b4aacb2fc737c24aacc95cf52b74414755751f75d515d75a4942a4b2637db130a543ed34929d51647c80440abac9c9f31a44f558752397f7e38cdf7f81b9e190c882c0b2f59839cba3291f5111af65255a27ce6ba4cccf2911f8d311f6e100229bbf33a2f8baaaa66f5112a7b5ea4e98e0f330885fc0d70c118e8e4d43d553261f5c44e6b226325ca5cc8a6b745a33d1292b492de4c2a1375973b8078c6133d15d59a2ba9a831e5c30b429372035eb72b181316514d7289a8b1f4d977ee191f5e1083248f52a65f851bd4bb88e6dc19501aed3da187e25b1f40dffa2d0b3c0388dbaa279fa6b1f5811dedfd91c20e78ff780dcd756ca4cc9dc19bf1ec681f80db5377d1fa30fa9064855d94393468d26229381043dc3524596108652e4d06591eb2141c8e21ee1a8e4f5f1f654e42c486f6dad3e2ae6002f47ad790bb811858bd6963ceb508d2b74a84bb47ee37d6071452995c7ac6ba39e9103b1a7d9f1627312446cc670d75b7b231c910431aed6cad7b33f7ba0f13488558fd2cff6c20272e606c4f62dc39640b43c28c1fba0ba1f767c9442259615f066fc293ac1227643f4b26107d2becd5908ff08c8edd651f16903221f667f9a5a039a91023dbf910409aec99d1b5092f9386a5200ee5c89a93db4a933d43ba34e165c2ec2d4d20c47ed5b72b197373936c0ecd186d38b6495a3261a8ae70684f9a36e0b92358004def1cca44a1bac254dc7a43e90f32c7495685a049cbfa902d6592505d612a6e5d65e91cf7d31d4a403ed08daf0a9309427585a9b9b1cafa9ee362ca6453d292c9417585a97962cdd58524abc259f5ea7b9918fad2536bc2200eadb92f8bbd569560262dce66c74495f979b03c5f495695f144d292d2db9a2c880978aef94eb2aa94454f6bc4f13198bef3e367e85955ce3c69b11cc4c4d5394ab28239e3a97b4926c57479922026e25412162f8f80c7e86bc36462dc5e9a2888837a287372fc5ff7929fa6008f2169614a6ab2baffb37bd14f4f8027f9fbbfddaf4747ee336b0221f6a52c01bf94bf407fe9a725c07a64c27c6c4d24c41ebce6a721c0f648d2fac0984c88d1d439e7a71f407374db834c24fa5a18559aeb108c79339ebe164652fb5534d72138f4b530b43aa7fcf40208cfdd1fddef64a2b144c44eea125092159b41213e7ebf1687fd615b3f65cb02f4ce78eade95c947b585db3a3d3c727ff2d307a07fa8b6701b69ac4352506de10af5a1fa37fd34014807aa2d5cf21abd2a481e9fb8a8b62a55977fdc0184ec6099589d7a6e158fd640bee8e90f3289d9705ab69aa83e66f907c5407fab58f7fe79ec9ef31f33405990b8caf0ce91fb2bdb14a01a485cd9ba373a7697fdc708501724ae2cd4bd54d7a8a8003c9ab80e8fdc9f2530b8ab988e34d30136a1db212450be3402087b50c77e7cecfe48a20268803fed54978b545df19d2ffb2459b1e113a02bf34da89c7a1a5cada6ee3d746f524d0144407b5d2c19bba963277e409202e89145f2a2f2daa836cf495200a9f0d977ee99d1ccbd2ec1b97778e4feb114b035aa7dbf794f8a240590388faa2f496012b45f9f09e452d504a53728ded36bf7c3000039f2af63f79c04f35b92bc3ed6e591fcb3de15b3023f077589f7a97cbd26be45050550011ae8ba64123f18cfdc270926327db38c56875a25ea5bb83539513d01c0633491c972f2b7f3643673efcb573d1e4793c6a7a236af358974d91ba6bf5793917e2fad94f47beb9ff19e384f4a544d00100d9f6456ea7f19000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000054c9534ffd1fa85349295b8985430000000049454e44ae426082);

-- --------------------------------------------------------

--
-- Table structure for table `schedules`
--

CREATE TABLE `schedules` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `schedule` blob NOT NULL,
  `status` varchar(255) NOT NULL,
  `reference` varchar(255) NOT NULL,
  `seatId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`id`, `userId`, `schedule`, `status`, `reference`, `seatId`) VALUES
(8, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', 'LJYBO7UFH8', 'A1'),
(10, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', 'AZ83Q01K6N', 'A1'),
(11, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', '2B10EP4KJV', 'A1'),
(12, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', '0Q1O3AAI25', 'A1'),
(13, 1, 0x323b4d616e696c613b436562753b31323a333020706d3b313a343520706d3b426f65696e67203733373b3138303b31322f31322f323032342031323a30303a303020616d3b33303030, 'Checked in', '7NR16NJOKI', 'A2'),
(14, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', '4526EZY11E', 'A3'),
(15, 1, 0x333b446176616f3b436c61726b3b393a313520616d3b31303a333020616d3b426f65696e67203733373b3230303b31332f31322f323032342031323a30303a303020616d3b34303030, 'Checked in', 'P8NLFG94RT', 'A1'),
(16, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Checked in', '9UHHBZAMB5', 'A2'),
(17, 1, 0x323b4d616e696c613b436562753b31323a333020706d3b313a343520706d3b426f65696e67203733373b3138303b31322f31322f323032342031323a30303a303020616d3b33303030, 'Checked in', 'ZZ16027CX9', 'A3'),
(18, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Checked in', '5G4CUAVGA3', 'A4'),
(19, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Checked in', 'EMXPKNV3OF', 'A1'),
(20, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Checked in', 'Z98NZU2ZH7', 'A2'),
(21, 1, 0x333b446176616f3b436c61726b3b393a313520616d3b31303a333020616d3b426f65696e67203733373b3230303b31332f31322f323032342031323a30303a303020616d3b34303030, 'Checked in', 'YHMGK62SNU', 'A1'),
(22, 1, 0x383b4261636f6c6f643b4361676179616e206465204f726f3b313a303020706d3b323a333020706d3b426f65696e67203733373b3131303b31382f31322f323032342031323a30303a303020616d3b34353030, 'Not Checked-In', '6ZW5MAN5ZB', 'A2'),
(23, 1, 0x333b446176616f3b436c61726b3b393a313520616d3b31303a333020616d3b426f65696e67203733373b3230303b31332f31322f323032342031323a30303a303020616d3b34303030, 'Not Checked-In', '22IVBVYO1D', 'A3'),
(24, 1, 0x363b50756572746f205072696e636573613b4d616e696c613b373a333020706d3b393a303020706d3b426f65696e67203733373b3133303b31362f31322f323032342031323a30303a303020616d3b36303030, 'Not Checked-In', 'Y4MCON78P5', 'A4'),
(25, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'K5IJNVH3DY', 'A5'),
(26, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'SR1EZE24LG', 'A1'),
(27, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Not Checked-In', '1A3C4G7MRW', 'A2'),
(28, 1, 0x31303b446176616f3b436562753b353a343020706d3b373a303020706d3b426f65696e67203733373b3134303b32302f31322f323032342031323a30303a303020616d3b34303030, 'Not Checked-In', '19QG5QCL6B', 'A3'),
(29, 1, 0x383b4261636f6c6f643b4361676179616e206465204f726f3b313a303020706d3b323a333020706d3b426f65696e67203733373b3131303b31382f31322f323032342031323a30303a303020616d3b34353030, 'Not Checked-In', 'WS69K6GCP3', 'A4'),
(30, 1, 0x383b4261636f6c6f643b4361676179616e206465204f726f3b313a303020706d3b323a333020706d3b426f65696e67203733373b3131303b31382f31322f323032342031323a30303a303020616d3b34353030, 'Not Checked-In', 'DAO94PDPR4', 'A5'),
(31, 1, 0x383b4261636f6c6f643b4361676179616e206465204f726f3b313a303020706d3b323a333020706d3b426f65696e67203733373b3131303b31382f31322f323032342031323a30303a303020616d3b34353030, 'Not Checked-In', 'H46YC4GX3Q', 'A1'),
(32, 1, 0x333b446176616f3b436c61726b3b393a313520616d3b31303a333020616d3b426f65696e67203733373b3230303b31332f31322f323032342031323a30303a303020616d3b34303030, 'Not Checked-In', 'ZNN2CYGVPX', 'A1'),
(33, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Not Checked-In', 'XJNEYH5GQH', 'A1'),
(34, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'OFUPTIPWYZ', 'A1'),
(35, 1, 0x363b50756572746f205072696e636573613b4d616e696c613b373a333020706d3b393a303020706d3b426f65696e67203733373b3133303b31362f31322f323032342031323a30303a303020616d3b36303030, 'Not Checked-In', 'CWBVMYAQ60', 'A1'),
(36, 1, 0x393b4d616e696c613b436c61726b3b31303a353020616d3b31323a313020706d3b426f65696e67203733373b3136303b31392f31322f323032342031323a30303a303020616d3b33303030, 'Not Checked-In', 'TQIRWT8K9G', 'A1'),
(37, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', '8WJ1EUT3OA', 'A1'),
(38, 1, 0x313b4e657720596f726b3b4c6f7320416e67656c65733b31303a323020706d3b31313a323020706d3b426f65696e67203733373b3135303b31312f31322f323032342031323a30303a303020616d3b3639, 'Not Checked-In', 'P0XFWVNPQ6', 'A1'),
(39, 1, 0x373b436562753b446176616f3b363a323020616d3b373a333520616d3b426f65696e67203733373b39303b31372f31322f323032342031323a30303a303020616d3b33353030, 'Not Checked-In', 'AGRE11V3G4', 'A1'),
(40, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', '1W9WQZIU7Z', 'A1'),
(41, 1, 0x363b50756572746f205072696e636573613b4d616e696c613b373a333020706d3b393a303020706d3b426f65696e67203733373b3133303b31362f31322f323032342031323a30303a303020616d3b36303030, 'Not Checked-In', 'FFMCUD07MR', 'A1'),
(42, 1, 0x31303b446176616f3b436562753b353a343020706d3b373a303020706d3b426f65696e67203733373b3134303b32302f31322f323032342031323a30303a303020616d3b34303030, 'Not Checked-In', '8OSDCRP8XQ', 'A1'),
(43, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', '3CLWKZKPOY', 'A1'),
(44, 1, 0x373b436562753b446176616f3b363a323020616d3b373a333520616d3b426f65696e67203733373b39303b31372f31322f323032342031323a30303a303020616d3b33353030, 'Not Checked-In', 'BCLCNFBWTA', 'A1'),
(45, 1, 0x333b446176616f3b436c61726b3b393a313520616d3b31303a333020616d3b426f65696e67203733373b3230303b31332f31322f323032342031323a30303a303020616d3b34303030, 'Not Checked-In', 'HL8TCY6CVA', 'A1'),
(46, 1, 0x363b50756572746f205072696e636573613b4d616e696c613b373a333020706d3b393a303020706d3b426f65696e67203733373b3133303b31362f31322f323032342031323a30303a303020616d3b36303030, 'Not Checked-In', '5K1FMOWCBX', 'A1'),
(47, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'PVMUUIOTSN', 'A1'),
(48, 1, 0x393b4d616e696c613b436c61726b3b31303a353020616d3b31323a313020706d3b426f65696e67203733373b3136303b31392f31322f323032342031323a30303a303020616d3b33303030, 'Not Checked-In', 'RHCABR36ZK', 'A1'),
(49, 1, 0x363b50756572746f205072696e636573613b4d616e696c613b373a333020706d3b393a303020706d3b426f65696e67203733373b3133303b31362f31322f323032342031323a30303a303020616d3b36303030, 'Not Checked-In', 'M8XLUX533Z', 'A1'),
(50, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'NVC8ODXR1Q', 'A1'),
(51, 1, 0x393b4d616e696c613b436c61726b3b31303a353020616d3b31323a313020706d3b426f65696e67203733373b3136303b31392f31322f323032342031323a30303a303020616d3b33303030, 'Not Checked-In', 'VBJN7LJGFS', 'A1'),
(52, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'B15WBOIL2J', 'A1'),
(53, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'FJXT6PUF9R', 'A1'),
(54, 1, 0x393b4d616e696c613b436c61726b3b31303a353020616d3b31323a313020706d3b426f65696e67203733373b3136303b31392f31322f323032342031323a30303a303020616d3b33303030, 'Not Checked-In', 'UXOCZI61AS', 'A1'),
(55, 1, 0x353b436c61726b3b5a616d626f616e67613b383a343520616d3b31303a303020616d3b426f65696e67203733373b3130303b31352f31322f323032342031323a30303a303020616d3b35303030, 'Not Checked-In', 'DKQAZ0DN0M', 'A1'),
(56, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Not Checked-In', 'DZKZLRFGKG', 'A1'),
(57, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Not Checked-In', 'IVZ3F3TS56', 'A1'),
(58, 1, 0x343b496c6f696c6f3b5461636c6f62616e3b323a303020706d3b333a313520706d3b426f65696e67203733373b3132303b31342f31322f323032342031323a30303a303020616d3b32353030, 'Not Checked-In', 'Y5QXXHURIH', 'A2');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
(1, '123', '123@gmail.com', 'Nathan123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aircrafts`
--
ALTER TABLE `aircrafts`
  ADD PRIMARY KEY (`aircraft_id`);

--
-- Indexes for table `flights`
--
ALTER TABLE `flights`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mail`
--
ALTER TABLE `mail`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_user_id` (`userId`);

--
-- Indexes for table `profiles`
--
ALTER TABLE `profiles`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `schedules`
--
ALTER TABLE `schedules`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aircrafts`
--
ALTER TABLE `aircrafts`
  MODIFY `aircraft_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `flights`
--
ALTER TABLE `flights`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `mail`
--
ALTER TABLE `mail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `profiles`
--
ALTER TABLE `profiles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `schedules`
--
ALTER TABLE `schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `mail`
--
ALTER TABLE `mail`
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`userId`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
