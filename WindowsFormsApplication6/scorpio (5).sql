-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 05, 2019 at 07:46 PM
-- Server version: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `scorpio`
--

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `cmnt_id` varchar(20) NOT NULL,
  `c_id` varchar(20) NOT NULL,
  `u_id` varchar(20) NOT NULL,
  `comment` varchar(10000) NOT NULL,
  `spoiler` varchar(1) NOT NULL,
  `date_time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`cmnt_id`, `c_id`, `u_id`, `comment`, `spoiler`, `date_time`) VALUES
('cmnt0DTZ71', 'c100000', 'arsal_islam', 'wow', '0', '2019-03-05 05:18:29'),
('cmnt1X4EGZ', 'c100000', 'mashnoor', 'a\r\nb\r\nc\r\nd\r\ne\r\nf\r\ng\r\nh\r\ni', '0', '2019-03-03 06:13:14'),
('cmnt2CHMXW', 'c100000', 'stinsonbarney', '2\r\n0\r\n1\r\n9\r\n2\r\n0\r\n1\r\n9\r\n2\r\n0\r\n1\r\n9\r\n', '1', '2019-03-01 07:14:18'),
('cmnt363X1A', 'c100000', 'sheksafwan', 'Frank!!', '1', '2019-03-26 08:36:03'),
('cmnt4S609S', 'c100000', 'akash', 'punisher !!!!!!!!!!!!!!!', '0', '2019-03-27 09:55:42');

-- --------------------------------------------------------

--
-- Table structure for table `comment_love`
--

CREATE TABLE `comment_love` (
  `cmnt_id` varchar(20) NOT NULL,
  `u_id` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comment_love`
--

INSERT INTO `comment_love` (`cmnt_id`, `u_id`) VALUES
('cmnt0DTZ71', 'akash'),
('cmnt1X4EGZ', 'arsal_islam'),
('cmnt1X4EGZ', 'shallow'),
('cmnt1X4EGZ', 'yepshita');

-- --------------------------------------------------------

--
-- Table structure for table `comment_reply`
--

CREATE TABLE `comment_reply` (
  `cmnt_id` varchar(20) NOT NULL,
  `c_id` varchar(20) NOT NULL,
  `u_id` varchar(20) NOT NULL,
  `comment` text NOT NULL,
  `spoiler` varchar(1) NOT NULL,
  `date_time` datetime NOT NULL,
  `parent` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `content`
--

CREATE TABLE `content` (
  `name` varchar(100) NOT NULL,
  `id` varchar(25) NOT NULL,
  `type` varchar(25) NOT NULL,
  `release_date` date NOT NULL,
  `poster` varchar(100) NOT NULL,
  `cover` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `content`
--

INSERT INTO `content` (`name`, `id`, `type`, `release_date`, `poster`, `cover`) VALUES
('The Punisher', 'c100000', 'TV', '2017-11-17', 'the punisher.jpg', 'punisher.jpg'),
('Friends', 'c100001', 'TV', '1994-09-22', 'friends.jpg', 'friends.jpg'),
('Westworld', 'c100002', 'TV', '2016-10-02', 'westworld.jpg', 'westworld.jpg'),
('You', 'c100003', 'TV', '2018-09-09', 'you.jpg', 'you.jpg'),
('Russian Doll', 'c100004', 'TV', '2019-02-01', 'russian doll.jpg', 'russian doll.jpg'),
('Game of Thrones', 'c100005', 'TV', '2011-04-17', 'game of thrones.jpg', 'game of thrones.jpg'),
('Breaking Bad', 'c100006', 'TV', '2008-01-20', 'breaking bad.jpg', 'breaking bad.jpg'),
('Glow', 'c100007', 'TV', '2019-06-23', 'glow.jpg', 'glow.jpg'),
('Strangers Things', 'c100008', 'TV', '2016-07-16', 'strangers things.jpg', 'strangers things.jpg'),
('Alita : Battle Angel', 'c100009', 'Movie', '2019-02-14', 'qe.jpg', 'alitareactlogo.jpg'),
('Aladdin', 'c100010', 'Movie', '2019-05-24', 'asd.jpg', NULL),
('John Wick', 'c100011', 'Movie', '2014-10-13', '1.jpg', NULL),
('John Wick 2', 'c100012', 'Movie', '2017-05-17', '2.jpg', NULL),
('John Wick 3', 'c100013', 'Movie', '2019-05-16', '3.jpg', NULL),
('The Umbrella Academy', 'c100014', 'TV', '2019-02-15', 'MV5BNTFhOTk1NTgtYWM1ZS00NWI1LTgzYzAtYmE5MjZiMDE0NzlhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg', NULL),
('Kingdom', 'c100015', 'TV', '2019-01-25', 'bZ748P1KBgzEywvUORVT9wYY6611916.jpg', 'kingdom-poster-2.png'),
('The Dragon Prince', 'c100016', 'TV', '2018-09-14', 'MV5BMjA5MjEwODU1MV5BMl5BanBnXkFtZTgwNzk0MzA5NTM@._V1_.jpg', NULL),
('Spider Man into the Spider Verse', 'c100017', 'Movie', '2019-03-28', 'spider man into the spider verse.jpg', NULL),
('Blade Runner 2049', 'c100018', 'Movie', '2019-03-28', 'blade runner 2049.jpg', NULL),
('A Quiet Place', 'c100019', 'Movie', '2019-03-21', 'a quiet place .jpg', NULL),
('Dunkirk', 'c100020', 'Movie', '2019-03-15', 'dunkirk.jpg', NULL),
('Dark', 'c100021', 'TV', '2019-03-15', 'aw62ganh7o801.jpg', NULL),
('Narcos', 'c100022', 'TV', '2016-03-28', '918+0D72yjL._SY445_.jpg', NULL),
('The Crown', 'c100023', 'TV', '2019-03-18', 'images.jpg', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `content_genres`
--

CREATE TABLE `content_genres` (
  `c_id` varchar(100) NOT NULL,
  `genre` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `content_genres`
--

INSERT INTO `content_genres` (`c_id`, `genre`) VALUES
('c100000', 'Action'),
('c100000', 'Adventure'),
('c100000', 'Crime'),
('c100001', 'Comedy'),
('c100001', 'Drama'),
('c100001', 'Romance'),
('c100002', 'Drama'),
('c100002', 'Mystery'),
('c100002', 'Science fiction'),
('c100003', 'Crime'),
('c100003', 'Drama'),
('c100003', 'Romance'),
('c100004', 'Comedy'),
('c100004', 'Drama'),
('c100004', 'Mystery'),
('c100005', 'Action'),
('c100005', 'Adventure'),
('c100005', 'Drama'),
('c100006', 'Crime'),
('c100006', 'Drama'),
('c100006', 'Thriller'),
('c100007', 'Comedy'),
('c100007', 'Drama'),
('c100007', 'Sport'),
('c100008', 'Drama'),
('c100008', 'Fantasy'),
('c100008', 'Horror'),
('c100009', 'Action'),
('c100009', 'Adventure'),
('c100009', 'Science fiction'),
('c100010', 'Adventure'),
('c100010', 'Comedy'),
('c100010', 'Family'),
('c100011', 'Action'),
('c100011', 'Crime'),
('c100011', 'Thriller'),
('c100012', 'Action'),
('c100012', 'Crime'),
('c100012', 'Thriller'),
('c100013', 'Action'),
('c100013', 'Crime'),
('c100013', 'Thriller'),
('c100014', 'Action'),
('c100014', 'Adventure'),
('c100014', 'Comedy'),
('c100015', 'Action'),
('c100015', 'Adventure'),
('c100015', 'Thriller'),
('c100016', 'Animation'),
('c100016', 'Family'),
('c100016', 'Fantasy'),
('c100017', 'Action'),
('c100017', 'Adventure'),
('c100017', 'Animation'),
('c100018', 'Drama'),
('c100018', 'Mystery'),
('c100018', 'Science fiction'),
('c100019', 'Drama'),
('c100019', 'Horror'),
('c100019', 'Mystery'),
('c100020', 'Action'),
('c100020', 'Drama'),
('c100020', 'History'),
('c100021', 'Crime'),
('c100021', 'Mystery'),
('c100021', 'Science fiction'),
('c100022', 'Biography'),
('c100022', 'Crime'),
('c100022', 'Thriller'),
('c100023', 'Drama'),
('c100023', 'History'),
('c100023', 'Thriller');

-- --------------------------------------------------------

--
-- Table structure for table `country`
--

CREATE TABLE `country` (
  `country` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `country`
--

INSERT INTO `country` (`country`) VALUES
('Colombia'),
('Germany'),
('S Korea'),
('USA');

-- --------------------------------------------------------

--
-- Table structure for table `episode`
--

CREATE TABLE `episode` (
  `id` varchar(20) NOT NULL,
  `ep` varchar(3) NOT NULL,
  `link480` varchar(100) NOT NULL,
  `link720` varchar(100) NOT NULL,
  `link1080` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `episode`
--

INSERT INTO `episode` (`id`, `ep`, `link480`, `link720`, `link1080`) VALUES
('e000000000', 'E01', '480.mp4', '720.mp4', '1080.mp4'),
('e000000001', 'E02', '480.mp4', '720.mp4', '1080.mp4'),
('e000000002', 'E03', '480.mp4', '720.mp4', '1080.mp4'),
('e000000003', 'E04', '480.mp4', '720.mp4', '1080.mp4'),
('e000000004', 'E05', '480.mp4', '720.mp4', '1080.mp4'),
('e000000005', 'E06', '480.mp4', '720.mp4', '1080.mp4'),
('e000000006', 'E07', '480.mp4', '720.mp4', '1080.mp4'),
('e000000007', 'E08', '480.mp4', '720.mp4', '1080.mp4'),
('e000000008', 'E09', '480.mp4', '720.mp4', '1080.mp4'),
('e000000009', 'E10', '480.mp4', '720.mp4', '1080.mp4'),
('e000000010', 'E11', '480.mp4', '720.mp4', '1080.mp4'),
('e000000011', 'E12', '480.mp4', '720.mp4', '1080.mp4'),
('e000000012', 'E01', '480.mp4', '720.mp4', '1080.mp4'),
('e000000013', 'E02', '480.mp4', '720.mp4', '1080.mp4'),
('e000000014', 'E03', '480.mp4', '720.mp4', '1080.mp4'),
('e000000015', 'E04', '480.mp4', '720.mp4', '1080.mp4'),
('e000000016', 'E05', '480.mp4', '720.mp4', '1080.mp4'),
('e000000017', 'E06', '480.mp4', '720.mp4', '1080.mp4'),
('e000000018', 'E07', '480.mp4', '720.mp4', '1080.mp4'),
('e000000019', 'E08', '480.mp4', '720.mp4', '1080.mp4'),
('e000000020', 'E09', '480.mp4', '720.mp4', '1080.mp4'),
('e000000021', 'E10', '480.mp4', '720.mp4', '1080.mp4'),
('e000000022', 'E11', '480.mp4', '720.mp4', '1080.mp4'),
('e000000023', 'E12', '480.mp4', '720.mp4', '1080.mp4'),
('e2471JZ5', 'E00', '480.mp4', '720.mp4', '1080.mp4'),
('e251J14N', 'E01', '480.mp4', '720.mp4', '1080.mp4'),
('e269NSLL', 'E02', '480.mp4', '720.mp4', '1080.mp4'),
('e27IGOPZ', 'E03', '480.mp4', '720.mp4', '1080.mp4'),
('e288EFR4', 'E04', '480.mp4', '720.mp4', '1080.mp4'),
('e29GPCZE', 'E05', '480.mp4', '720.mp4', '1080.mp4');

-- --------------------------------------------------------

--
-- Stand-in structure for view `ep_stat`
-- (See below for the actual view)
--
CREATE TABLE `ep_stat` (
`u_id` varchar(20)
,`no` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `genre` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`genre`) VALUES
('Action'),
('Adventure'),
('Animation'),
('Biography'),
('Comedy'),
('Crime'),
('Drama'),
('Family'),
('Fantasy'),
('History'),
('Horror'),
('Mystery'),
('Political'),
('Romance'),
('Science fiction'),
('Sport'),
('Thriller'),
('Western');

-- --------------------------------------------------------

--
-- Table structure for table `history_movie`
--

CREATE TABLE `history_movie` (
  `u_id` varchar(20) NOT NULL,
  `c_id` varchar(100) NOT NULL,
  `date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `history_movie`
--

INSERT INTO `history_movie` (`u_id`, `c_id`, `date`) VALUES
('akash', 'c100009', ' 07/10/2018 05:50:06'),
('akash', 'c100011', ' 07/11/2018 05:50:06'),
('akash', 'c100012', ' 08/10/2018 05:50:06'),
('akash', 'c100018', ' 09/11/2018 05:50:06'),
('akash', 'c100019', ' 08/10/2018 05:50:06');

-- --------------------------------------------------------

--
-- Table structure for table `history_tv`
--

CREATE TABLE `history_tv` (
  `u_id` varchar(20) NOT NULL,
  `e_id` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `history_tv`
--

INSERT INTO `history_tv` (`u_id`, `e_id`, `date`) VALUES
('akash', 'e000000000', ' 07/10/2018 05:50:06'),
('akash', 'e000000001', ' 07/10/2018 06:50:06'),
('akash', 'e000000002', ' 07/10/2018 07:50:06'),
('akash', 'e000000003', ' 07/10/2018 08:50:06'),
('akash', 'e000000004', ' 07/10/2018 09:50:06'),
('akash', 'e000000005', ' 07/11/2018 07:50:06'),
('akash', 'e000000006', ' 07/11/2018 08:50:06'),
('akash', 'e000000007', ' 07/12/2018 07:50:06'),
('akash', 'e000000008', ' 07/12/2018 08:50:06'),
('akash', 'e000000009', ' 07/12/2018 09:50:06'),
('akash', 'e000000010', ' 07/13/2018 07:50:06'),
('akash', 'e000000011', ' 07/13/2018 08:50:06'),
('akash', 'e000000012', ' 07/14/2018 07:50:06'),
('akash', 'e000000013', ' 07/14/2018 08:50:06'),
('akash', 'e000000014', ' 07/14/2018 09:50:06'),
('akash', 'e000000015', ' 07/15/2018 07:50:06'),
('akash', 'e000000016', ' 07/15/2018 08:50:06'),
('akash', 'e000000017', ' 07/15/2018 09:50:06'),
('akash', 'e000000018', ' 07/16/2018 07:50:06'),
('akash', 'e000000019', ' 07/16/2018 08:50:06'),
('akash', 'e000000020', ' 07/16/2018 09:50:06'),
('akash', 'e000000021', ' 07/16/2018 10:50:06'),
('akash', 'e000000022', ' 07/16/2018 11:50:06'),
('akash', 'e000000023', ' 07/16/2018 12:50:06');

-- --------------------------------------------------------

--
-- Stand-in structure for view `history_user`
-- (See below for the actual view)
--
CREATE TABLE `history_user` (
`name` varchar(108)
,`id` varchar(25)
,`date` varchar(100)
,`u_id` varchar(20)
);

-- --------------------------------------------------------

--
-- Table structure for table `hit_content`
--

CREATE TABLE `hit_content` (
  `c_id` varchar(100) NOT NULL,
  `hit` bigint(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hit_content`
--

INSERT INTO `hit_content` (`c_id`, `hit`) VALUES
('c100000', 100000),
('c100001', 98000),
('c100002', 96500),
('c100003', 10000),
('c100004', 70000),
('c100005', 100000),
('c100006', 97000),
('c100007', 20000),
('c100008', 96000),
('c100009', 50000),
('c100010', 1000),
('c100011', 70000),
('c100012', 60000),
('c100013', 4000),
('c100014', 50000),
('c100015', 45631),
('c100016', 9000),
('c100017', 8000),
('c100018', 5000),
('c100019', 4000),
('c100020', 6000);

-- --------------------------------------------------------

--
-- Table structure for table `hit_season`
--

CREATE TABLE `hit_season` (
  `s_id` varchar(20) NOT NULL,
  `hit` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hit_season`
--

INSERT INTO `hit_season` (`s_id`, `hit`) VALUES
('s10000', 70000),
('s10001', 80000),
('s10002', 91000),
('s10003', 90000),
('s10004', 1000),
('s10005', 77000),
('s10006', 88000),
('s10007', 80000),
('s10008', 80000),
('s10009', 70000),
('s10010', 5000),
('s10012', 7500),
('s10013', 8000),
('s10014', 5600);

-- --------------------------------------------------------

--
-- Table structure for table `hot_content`
--

CREATE TABLE `hot_content` (
  `c_id` varchar(20) NOT NULL,
  `value` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hot_content`
--

INSERT INTO `hot_content` (`c_id`, `value`) VALUES
('c100000', 80),
('c100001', 95),
('c100002', 90),
('c100003', 70),
('c100004', 77),
('c100005', 96),
('c100006', 94),
('c100007', 68),
('c100008', 88),
('c100009', 77),
('c100010', 70),
('c100011', 70),
('c100012', 67),
('c100013', 75),
('c100014', 75),
('c100015', 65),
('c100016', 59),
('c100017', 70),
('c100018', 80),
('c100019', 72),
('c100020', 76),
('c100021', 73),
('c100022', 82),
('c100023', 77);

-- --------------------------------------------------------

--
-- Table structure for table `inbox`
--

CREATE TABLE `inbox` (
  `i_id` varchar(20) NOT NULL,
  `u_id` varchar(20) NOT NULL,
  `message` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inbox`
--

INSERT INTO `inbox` (`i_id`, `u_id`, `message`) VALUES
('0UH60P', 'akassh', 'Your account is created as a staff. User name : 11O2Q9Q and password : K4BEF0J6ETG5. Change your username and password and also update your profile information');

-- --------------------------------------------------------

--
-- Table structure for table `info_series`
--

CREATE TABLE `info_series` (
  `c_id` varchar(20) NOT NULL,
  `creator` varchar(20) NOT NULL,
  `star1` varchar(20) NOT NULL,
  `star2` varchar(20) NOT NULL,
  `star3` varchar(20) NOT NULL,
  `rated` varchar(20) NOT NULL,
  `plot` text NOT NULL,
  `tag` varchar(1000) NOT NULL,
  `country` varchar(20) NOT NULL,
  `language` varchar(20) NOT NULL,
  `last_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `info_series`
--

INSERT INTO `info_series` (`c_id`, `creator`, `star1`, `star2`, `star3`, `rated`, `plot`, `tag`, `country`, `language`, `last_date`) VALUES
('c100000', 'Steve Lightfoot', 'Jon Bernthal', 'Amber Rose Revah', 'Ben Barnes', 'TV-MA', 'After the murder of his family, Marine veteran Frank Castle becomes the vigilante known as \"The Punisher,\" with only one goal in mind: to avenge them.', 'The truth must be taken.', 'USA', 'English', '2019-01-18'),
('c100004', 'Leslye Headland', 'Natasha Lyonne', 'Charlie Barnett', 'Greta Lee', 'TV-MA', 'A cynical young woman in New York City keeps dying and returning to the party that\'s being thrown in her honor on that same evening. She tries to find a way out of this strange time loop.', 'Dying is Easy. It\'s Living That\'s Hard.', 'USA', 'English', NULL),
('c100009', 'Robert Rodriguez', 'Rosa Salazar', 'Christoph Waltz', 'Jennifer Connelly', 'PG-13', 'Alita is a creation from an age of despair. Found by the mysterious Dr. Ido while trolling for cyborg parts, Alita becomes a lethal, dangerous being. She cannot remember who she is, or where she came from. But to Dr. Ido, the truth is all too clear. She is the one being who can break the cycle of death and destruction left behind from Tiphares. But to accomplish her true purpose, she must fight and kill. And that is where Alita\'s true significance comes to bear. She is an angel from heaven. She is an angel of death. ', 'She searched for her Past, and found her Destiny.', 'USA', 'English', NULL),
('c100015', 'Kim Sung Hoon', ' Doona Bae,', 'Jun-ho Heo ', 'Greg Chun', 'TV-MA', 'While strange rumors about their ill king grip a kingdom, the crown prince becomes their only hope against a mysterious plague overtaking the land.', 'zombie apocalypse', 'S Korea', 'Korean', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `language`
--

CREATE TABLE `language` (
  `language` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `language`
--

INSERT INTO `language` (`language`) VALUES
('English'),
('German'),
('Korean');

-- --------------------------------------------------------

--
-- Table structure for table `log_in`
--

CREATE TABLE `log_in` (
  `login_id` varchar(100) NOT NULL,
  `u_id` varchar(100) NOT NULL,
  `date_time` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `log_in`
--

INSERT INTO `log_in` (`login_id`, `u_id`, `date_time`) VALUES
('0adads', 'akash', '04/03/2019 05:50:06'),
('l100MGP46', 'akash', '04/05/2019 19:07:34'),
('l101IXIHP', 'akash', '04/05/2019 19:08:13'),
('l102QWB95', 'akash', '04/05/2019 19:10:28'),
('l103C7G0E', 'akash', '04/05/2019 19:10:44'),
('l1046MQR2', 'navin', '04/05/2019 19:10:59'),
('l1053B982', 'akash', '04/05/2019 19:11:20'),
('l106VPO0C', 'navin', '04/05/2019 19:12:08'),
('l107ZND3C', 'navin', '04/05/2019 19:12:23'),
('l1082K6I8', 'akash', '04/05/2019 19:13:05'),
('l109ET3W9', 'akash', '04/05/2019 19:13:38'),
('l10D9SHS', 'akash', '04/05/2019 00:25:47'),
('l110RKW4P', 'navin', '04/05/2019 19:13:48'),
('l111OO4BA', 'akash', '04/05/2019 19:14:55'),
('l112YJ4LQ', 'akash', '04/05/2019 19:15:10'),
('l113E7I54', 'akash', '04/05/2019 19:15:27'),
('l114H2GRC', 'navin', '04/05/2019 19:15:38'),
('l115ZYJ49', 'navin', '04/05/2019 19:16:08'),
('l1164KL78', 'navin', '04/05/2019 19:18:41'),
('l117SJ79W', 'akash', '04/05/2019 19:18:54'),
('l1189ZO0D', 'akash', '04/05/2019 19:19:05'),
('l119VEQ9N', 'akash', '04/05/2019 19:20:11'),
('l11VC6DQ', 'akash', '04/05/2019 00:27:19'),
('l120NOIUE', 'navin', '04/05/2019 19:23:51'),
('l121PLQAK', 'navin', '04/05/2019 19:29:31'),
('l1220K6YQ', 'akash', '04/05/2019 19:35:17'),
('l123895E2', 'akash', '04/05/2019 19:35:39'),
('l124TWPVS', 'akash', '04/05/2019 19:37:57'),
('l125RAQ4T', 'akash', '04/05/2019 19:39:43'),
('l126QE7NK', 'akash', '04/05/2019 19:41:01'),
('l1275Y3LF', 'akash', '04/05/2019 19:41:27'),
('l1284Q5R5', 'akash', '04/05/2019 19:45:41'),
('l129WDVYB', 'akash', '04/05/2019 19:46:04'),
('l12YCX43', 'akash', '04/05/2019 00:27:50'),
('l13023FRY', 'akash', '04/05/2019 19:46:37'),
('l1318625P', 'akash', '04/05/2019 19:47:01'),
('l132NX1F6', 'akash', '04/05/2019 19:48:04'),
('l133OVG6C', 'akash', '04/05/2019 19:48:57'),
('l134MA1LA', 'akash', '04/05/2019 19:49:19'),
('l135N1NU6', 'akash', '04/05/2019 19:49:39'),
('l136DXHOV', 'akash', '04/05/2019 19:49:56'),
('l137CKDVI', 'akash', '04/05/2019 19:50:29'),
('l1381PK82', 'akash', '04/05/2019 19:50:50'),
('l1389T0Z', 'akash', '04/05/2019 00:29:02'),
('l139VPQDO', 'akash', '04/05/2019 20:19:02'),
('l14037Y08', 'akash', '04/05/2019 20:20:07'),
('l1419Z67F', 'akash', '04/05/2019 20:24:30'),
('l142G5K8I', 'akash', '04/05/2019 20:25:58'),
('l143C1U0B', 'akash', '04/05/2019 20:35:40'),
('l144WFRK7', 'akash', '04/05/2019 20:40:25'),
('l145XKMNU', 'akash', '04/05/2019 20:45:53'),
('l146CJIGC', 'akash', '04/05/2019 20:48:49'),
('l147JQIIL', 'akash', '04/05/2019 21:02:06'),
('l148KQJVE', 'akash', '04/05/2019 21:02:42'),
('l149O1OB1', 'akash', '04/05/2019 21:03:18'),
('l14DJIW8', 'akash', '04/05/2019 00:30:40'),
('l15036P6Z', 'akash', '04/05/2019 21:03:49'),
('l1518B71M', 'akash', '04/05/2019 21:04:08'),
('l152D9H1H', 'akash', '04/05/2019 21:07:05'),
('l152RGQL', 'akash', '04/05/2019 00:31:04'),
('l153NAZER', 'akash', '04/05/2019 21:24:38'),
('l1544RZK6', 'akash', '04/05/2019 21:25:28'),
('l155TQ9KT', 'akash', '04/05/2019 21:26:27'),
('l156L1962', 'akash', '04/05/2019 21:45:42'),
('l1571U4P5', 'akash', '04/05/2019 21:46:02'),
('l158MLCAA', 'akash', '04/05/2019 21:47:19'),
('l159GNULY', 'akash', '04/05/2019 21:48:09'),
('l160X2W66', 'akash', '04/05/2019 21:52:53'),
('l161V938H', 'akash', '04/05/2019 21:56:43'),
('l16220FKO', 'akash', '04/05/2019 21:57:39'),
('l163F361S', 'akash', '04/05/2019 22:01:39'),
('l164OEZYO', 'akash', '04/05/2019 22:02:38'),
('l165FAEKP', 'akash', '04/05/2019 22:04:37'),
('l1667PRHO', 'john_snow', '04/05/2019 22:11:20'),
('l167V9XFF', 'akash', '04/05/2019 22:19:20'),
('l168TJGEF', 'john_snow', '04/05/2019 22:19:35'),
('l1698CRYR', 'john_snow', '04/05/2019 22:21:21'),
('l16WV8FE', 'akash', '04/05/2019 00:31:19'),
('l1700J03K', 'john_snow', '04/05/2019 22:24:22'),
('l1706N4P', 'akash', '04/05/2019 00:43:14'),
('l171U1B9W', 'john_snow', '04/05/2019 22:25:30'),
('l172ZXA8W', 'john_snow', '04/05/2019 22:26:18'),
('l173BSC9Y', 'akash', '04/05/2019 22:27:46'),
('l17429LXV', 'john_snow', '04/05/2019 22:28:06'),
('l175LY26X', 'akash', '04/05/2019 22:28:47'),
('l176LJM7P', 'john_snow', '04/05/2019 22:29:04'),
('l18LLSRJ', 'akash', '04/05/2019 00:47:20'),
('l19VR4Z3', 'akash', '04/05/2019 01:10:48'),
('l1KKOOQ', 'akash', '04/03/2019 22:38:30'),
('l20FTT7Y', 'akash', '04/05/2019 01:11:38'),
('l214H35D', 'akash', '04/05/2019 01:11:59'),
('l22IFTUC', 'akash', '04/05/2019 01:15:02'),
('l23008TG', 'akash', '04/05/2019 01:17:15'),
('l24CS5MO', 'akash', '04/05/2019 01:18:45'),
('l253DAYE', 'john_snow', '04/05/2019 01:19:18'),
('l26RIP57', 'john_snow', '04/05/2019 01:19:51'),
('l27WUXVB', 'akash', '04/05/2019 01:33:50'),
('l285XJIW', 'akash', '04/05/2019 01:34:21'),
('l29S8ORJ', 'akash', '04/05/2019 12:39:17'),
('l2JFN7X', 'akash', '04/03/2019 22:42:32'),
('l30KSL95', 'akash', '04/05/2019 12:40:36'),
('l31RC24M', 'akash', '04/05/2019 12:41:31'),
('l32UU0GX', 'akash', '04/05/2019 12:41:55'),
('l33THG7N', 'akash', '04/05/2019 12:44:34'),
('l34K9ZA8', 'akash', '04/05/2019 13:32:54'),
('l35ZHU78', 'akash', '04/05/2019 14:56:10'),
('l3606QHL', 'akash', '04/05/2019 14:58:08'),
('l37JJB4F', 'akash', '04/05/2019 15:01:23'),
('l382MB5Y', 'akash', '04/05/2019 15:01:53'),
('l39GY35D', 'akash', '04/05/2019 15:02:21'),
('l3SL7XM', 'akash', '04/03/2019 22:56:59'),
('l40SRZD6', 'akash', '04/05/2019 15:06:56'),
('l41JUAJO', 'akash', '04/05/2019 15:07:28'),
('l42CAOBB', 'akash', '04/05/2019 15:07:53'),
('l43KT0HC', 'akash', '04/05/2019 15:08:38'),
('l44CPMUK', 'akash', '04/05/2019 15:09:20'),
('l45CIXBG', 'akash', '04/05/2019 15:12:31'),
('l46W16IN', 'akash', '04/05/2019 15:13:30'),
('l47YTXT9', 'akash', '04/05/2019 15:15:11'),
('l48CUXS9', 'akash', '04/05/2019 15:16:13'),
('l49CPEU6', 'akash', '04/05/2019 15:16:41'),
('l4CXY8V', 'akash', '04/05/2019 00:19:10'),
('l50TI9D8', 'akash', '04/05/2019 15:17:01'),
('l51YM4W9', 'akash', '04/05/2019 15:19:42'),
('l5219D69', 'akash', '04/05/2019 15:26:59'),
('l536ZG1P', 'akash', '04/05/2019 15:27:58'),
('l54R21XO', 'akash', '04/05/2019 15:28:19'),
('l55YH5GE', 'akash', '04/05/2019 15:29:55'),
('l56ZZVPS', 'akash', '04/05/2019 15:30:58'),
('l57WDMEY', 'akash', '04/05/2019 15:31:20'),
('l58LWUSO', 'akash', '04/05/2019 15:35:11'),
('l59ZYSQ0', 'akash', '04/05/2019 15:35:49'),
('l5KCRL3', 'akash', '04/05/2019 00:20:29'),
('l606NS3R', 'akash', '04/05/2019 15:41:23'),
('l61ERH2K', 'akash', '04/05/2019 15:41:59'),
('l62FRA08', 'akash', '04/05/2019 15:45:54'),
('l63DZRTW', 'akash', '04/05/2019 15:46:30'),
('l64LK2UY', 'akash', '04/05/2019 15:53:27'),
('l658JCMD', 'akash', '04/05/2019 15:54:50'),
('l66SXW7V', 'akash', '04/05/2019 15:55:10'),
('l67ZNQ33', 'akash', '04/05/2019 15:55:28'),
('l68B35RC', 'akash', '04/05/2019 15:55:46'),
('l69DFOCW', 'akash', '04/05/2019 15:56:07'),
('l6YDRWT', 'akash', '04/05/2019 00:22:10'),
('l700ZYDS', 'akash', '04/05/2019 15:56:28'),
('l71HVWTG', 'akash', '04/05/2019 15:56:40'),
('l72D20M9', 'akash', '04/05/2019 15:57:13'),
('l737ZDLB', 'akash', '04/05/2019 15:57:26'),
('l74X91XJ', 'akash', '04/05/2019 15:57:49'),
('l75IBNT6', 'akash', '04/05/2019 15:58:34'),
('l76EBN4S', 'akash', '04/05/2019 15:59:18'),
('l77FLSZK', 'akash', '04/05/2019 16:10:39'),
('l78SF1XJ', 'akash', '04/05/2019 16:12:49'),
('l79ZF01B', 'akash', '04/05/2019 16:13:13'),
('l7A7ANG', 'akash', '04/05/2019 00:24:00'),
('l80IOIE2', 'akash', '04/05/2019 16:13:27'),
('l81C1AG0', 'akash', '04/05/2019 16:21:40'),
('l82WK1V2', 'akash', '04/05/2019 16:24:40'),
('l83JETCD', 'akash', '04/05/2019 16:40:10'),
('l842LXV2', 'akash', '04/05/2019 16:42:19'),
('l854664S', 'akash', '04/05/2019 16:43:49'),
('l86TJZGI', 'akash', '04/05/2019 16:44:37'),
('l87BRQMI', 'john_snow', '04/05/2019 17:28:58'),
('l88PCRQT', 'john_snow', '04/05/2019 17:42:43'),
('l89CAY9G', 'john_snow', '04/05/2019 17:46:53'),
('l8CHTOM', 'akash', '04/05/2019 00:24:33'),
('l90FAPN7', 'akash', '04/05/2019 18:50:13'),
('l911JPD5', 'akash', '04/05/2019 18:57:45'),
('l92TO1OP', 'akash', '04/05/2019 19:02:37'),
('l938F5HN', 'navin', '04/05/2019 19:03:21'),
('l94O5HD6', 'akash', '04/05/2019 19:03:53'),
('l95ULCPU', 'akash', '04/05/2019 19:04:41'),
('l96F7HXA', 'akash', '04/05/2019 19:05:22'),
('l97392G5', 'navin', '04/05/2019 19:05:33'),
('l988T7H9', 'akash', '04/05/2019 19:06:21'),
('l995W7B8', 'akash', '04/05/2019 19:06:54'),
('l9YYUX8', 'akash', '04/05/2019 00:25:15');

-- --------------------------------------------------------

--
-- Table structure for table `movie_play`
--

CREATE TABLE `movie_play` (
  `m_id` varchar(100) NOT NULL,
  `link480` varchar(100) NOT NULL,
  `link720` varchar(100) NOT NULL,
  `link1080` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movie_play`
--

INSERT INTO `movie_play` (`m_id`, `link480`, `link720`, `link1080`) VALUES
('c100009', '480.mp4', '720.mp4', '1080.mp4');

-- --------------------------------------------------------

--
-- Stand-in structure for view `movie_stat`
-- (See below for the actual view)
--
CREATE TABLE `movie_stat` (
`u_id` varchar(20)
,`movie` bigint(21)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `no_of_ep`
-- (See below for the actual view)
--
CREATE TABLE `no_of_ep` (
`id` varchar(20)
,`season` varchar(3)
,`no_of_ep` bigint(21)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `no_of_season`
-- (See below for the actual view)
--
CREATE TABLE `no_of_season` (
`name` varchar(100)
,`id` varchar(25)
,`no_of_season` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `payment_netry`
--

CREATE TABLE `payment_netry` (
  `p_id` varchar(100) NOT NULL,
  `u_id` varchar(100) NOT NULL,
  `submited_on` varchar(100) NOT NULL,
  `valid_till` varchar(100) NOT NULL,
  `purchased_type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment_netry`
--

INSERT INTO `payment_netry` (`p_id`, `u_id`, `submited_on`, `valid_till`, `purchased_type`) VALUES
('12313', 'navin', '2019-03-20 11:59:59\r\n', '2019-03-21 11:59:59\r\n', 'Basic'),
('adsasd', 'john_snow', '2019-04-05 06:29:08', '2019-04-30 11:59:59', 'Premium'),
('p0QL603', 'john_snow', '2019-04-05 05:29:08', '2019-04-30 11:59:59', 'Basic'),
('p3UOCII', 'navin', '2019-04-05 07:29:35', '2019-04-30 11:59:59', 'Basic');

-- --------------------------------------------------------

--
-- Table structure for table `plan`
--

CREATE TABLE `plan` (
  `name` varchar(20) NOT NULL,
  `price` double NOT NULL,
  `screen` varchar(2) NOT NULL,
  `quality` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plan`
--

INSERT INTO `plan` (`name`, `price`, `screen`, `quality`) VALUES
('Basic', 4.99, '1', 'SD'),
('Premium', 12.99, '4', 'UHD'),
('Standard', 7.99, '2', 'HD');

-- --------------------------------------------------------

--
-- Table structure for table `rating_content`
--

CREATE TABLE `rating_content` (
  `u_id` varchar(20) NOT NULL,
  `c_id` varchar(100) NOT NULL,
  `rate` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `season`
--

CREATE TABLE `season` (
  `id` varchar(20) NOT NULL,
  `no` varchar(3) NOT NULL,
  `noofep` int(11) NOT NULL,
  `release_date` date NOT NULL,
  `poster` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `season`
--

INSERT INTO `season` (`id`, `no`, `noofep`, `release_date`, `poster`) VALUES
('s10000', 'S01', 12, '2017-11-17', 'the punisherseason1.jpeg'),
('s10001', 'S02', 12, '2019-01-18', 'the punisher.jpg'),
('s10002', 'S01', 8, '2016-07-15', 'asdasd.jpg'),
('s10003', 'S02', 9, '2017-10-27', 'ssasd.jpg'),
('s10004', 'S03', 0, '2019-07-04', 'strangers things.jpg'),
('s10005', 'S01', 10, '2018-09-09', 'you.jpg'),
('s10006', 'S01', 10, '2016-10-02', 'Screen-Shot-2016-12-05-at-9.53.19-AM.png'),
('s10007', 'S02', 10, '2018-04-22', 'west world.jpg'),
('s10008', 'S01', 8, '2019-02-01', 'russian doll.jpg'),
('s10009', 'S01', 10, '2017-06-23', 'glow.jpg'),
('s10010', 'S08', 6, '2019-04-14', 'game of thrones.jpg'),
('s10012', 'S01', 10, '2019-02-15', 'MV5BNTFhOTk1NTgtYWM1ZS00NWI1LTgzYzAtYmE5MjZiMDE0NzlhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg'),
('s10013', 'S01', 9, '2018-09-14', 'MV5BZDkzYzZjMmItYmE1Ny00MzJkLWFkOGItOWRiNjA0M2RiOWY2XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg'),
('s10014', 'S02', 9, '2019-02-15', 'MV5BMjA5MjEwODU1MV5BMl5BanBnXkFtZTgwNzk0MzA5NTM@._V1_.jpg'),
('s10015', 'S01', 10, '2019-03-15', 'aw62ganh7o801.jpg'),
('s10016', 'S01', 10, '2016-03-28', 'wagner-moura-in-narcos.jpg'),
('s10017', 'S02', 10, '2017-11-17', 'narcos_s2_bullet_face.jpg'),
('s10018', 'S03', 10, '2019-03-28', '918+0D72yjL._SY445_.jpg'),
('s10019', 'S01', 8, '2019-03-27', 'images.jpg'),
('s10020', 'S01', 10, '2011-04-17', 'Game_of_Thrones_Season_1.jpg'),
('s10021', 'S02', 10, '2012-04-01', 'Game_of_Thrones_Season_2.jpg'),
('s10022', 'S03', 10, '2013-03-31', 'Game_of_Thrones_Season_3.jpg'),
('s10023', 'S04', 10, '2014-04-06', 'Game_of_Thrones_Season_4.jpg'),
('s10024', 'S05', 10, '2015-04-12', 'Game_of_Thrones_Season_4.jpg'),
('s10025', 'S06', 10, '2016-04-24', 'Game_of_Thrones_Season_6.jpeg'),
('s10026', 'S07', 7, '2017-07-17', 'Grupo-Erik-Editores-Grupo-Erik-Editores-Poster-Game-Of-Thrones-Season-7-Night-King-115925823.jpg'),
('s27FJFP1', 'S01', 6, '0000-00-00', 'bZ748P1KBgzEywvUORVT9wYY6611916.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `season_ep`
--

CREATE TABLE `season_ep` (
  `s_id` varchar(20) NOT NULL,
  `e_id` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `season_ep`
--

INSERT INTO `season_ep` (`s_id`, `e_id`) VALUES
('s10000', 'e000000000'),
('s10000', 'e000000001'),
('s10000', 'e000000002'),
('s10000', 'e000000003'),
('s10000', 'e000000004'),
('s10000', 'e000000005'),
('s10000', 'e000000006'),
('s10000', 'e000000007'),
('s10000', 'e000000008'),
('s10000', 'e000000009'),
('s10000', 'e000000010'),
('s10000', 'e000000011'),
('s10001', 'e000000012'),
('s10001', 'e000000013'),
('s10001', 'e000000014'),
('s10001', 'e000000015'),
('s10001', 'e000000016'),
('s10001', 'e000000017'),
('s10001', 'e000000018'),
('s10001', 'e000000019'),
('s10001', 'e000000020'),
('s10001', 'e000000021'),
('s10001', 'e000000022'),
('s10001', 'e000000023'),
('s27FJFP1', 'e2471JZ5'),
('s27FJFP1', 'e251J14N'),
('s27FJFP1', 'e269NSLL'),
('s27FJFP1', 'e27IGOPZ'),
('s27FJFP1', 'e288EFR4'),
('s27FJFP1', 'e29GPCZE');

-- --------------------------------------------------------

--
-- Table structure for table `slideshow`
--

CREATE TABLE `slideshow` (
  `content_id` varchar(32) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `slideshow`
--

INSERT INTO `slideshow` (`content_id`, `status`) VALUES
('c100000', ''),
('c100004', ''),
('c100009', ''),
('c100015', '');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`type`) VALUES
('Admin'),
('Moderator'),
('staff');

-- --------------------------------------------------------

--
-- Table structure for table `staff_entry`
--

CREATE TABLE `staff_entry` (
  `s_id` varchar(100) NOT NULL,
  `u_id` varchar(100) NOT NULL,
  `stype` varchar(100) NOT NULL,
  `submitted_on` varchar(100) NOT NULL,
  `valid_till` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff_entry`
--

INSERT INTO `staff_entry` (`s_id`, `u_id`, `stype`, `submitted_on`, `valid_till`) VALUES
('13123123', 'akash', 'Moderator', '2019-03-30 11:59:59', '2020-03-30 11:59:59'),
('dasf', 'akash', 'Admin', '2019-04-05 11:59:59', '2020-04-05 11:59:59');

-- --------------------------------------------------------

--
-- Table structure for table `tv_season`
--

CREATE TABLE `tv_season` (
  `c_id` varchar(20) NOT NULL,
  `s_id` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tv_season`
--

INSERT INTO `tv_season` (`c_id`, `s_id`) VALUES
('c100000', 's10000'),
('c100000', 's10001'),
('c100002', 's10006'),
('c100002', 's10007'),
('c100003', 's10005'),
('c100004', 's10008'),
('c100005', 's10010'),
('c100005', 's10020'),
('c100005', 's10021'),
('c100005', 's10022'),
('c100005', 's10023'),
('c100005', 's10024'),
('c100005', 's10025'),
('c100005', 's10026'),
('c100007', 's10009'),
('c100008', 's10002'),
('c100008', 's10003'),
('c100008', 's10004'),
('c100014', 's10012'),
('c100015', 's27FJFP1'),
('c100016', 's10013'),
('c100016', 's10014'),
('c100021', 's10015'),
('c100022', 's10016'),
('c100022', 's10017'),
('c100022', 's10018'),
('c100023', 's10019');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `First_name` varchar(32) DEFAULT NULL,
  `Last_name` varchar(32) DEFAULT NULL,
  `User_name` varchar(32) NOT NULL,
  `Email` varchar(46) NOT NULL,
  `Password` varchar(46) NOT NULL,
  `Phone_no` varchar(11) DEFAULT NULL,
  `Birth_date` varchar(11) DEFAULT NULL,
  `Region` varchar(20) NOT NULL,
  `dp` varchar(150) NOT NULL,
  `joined` varchar(100) NOT NULL,
  `info_show` varchar(1) NOT NULL,
  `other_show` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`First_name`, `Last_name`, `User_name`, `Email`, `Password`, `Phone_no`, `Birth_date`, `Region`, `dp`, `joined`, `info_show`, `other_show`) VALUES
('Akash', 'Ahmed', 'akash', 'akash@gmail.com', '1234', '0156324986', '1993-06-20', 'Bangladesh', '44100037_368573597017657_8611665679113781248_n.jpg', '03/03/2019 ', '0', '0'),
(NULL, NULL, 'akassh', 'akassssssh@gmail.com', 'K4BEF0J6ETG5', NULL, NULL, '', 'default', '03/03/2019 ', '', ''),
('Arsal', 'Islam', 'arsal_islam', 'arsal@yahoo.com', '8949', '01737776543', '18-12-1990', 'Pakistan', 'default.png', '03/03/2019 ', '', ''),
('John', 'Snow', 'john_snow', 'iknownothing@gmail.com', '1234', '01546009883', '02-01-1989', 'USA', '44197093_368180767056940_7969905021431054336_n.jpg', '03/03/2019 ', '0', '1'),
('Nowfel', 'Mashnoor', 'mashnoor', 'mashnoor@gmail.com', '9877', '01523566678', '26-12-1996', 'Bangladesh', 'default.png', '03/03/2019 ', '', ''),
('Navin', 'Talukder', 'navin', 'navin@gmail.com', '1234', '01886304583', '17-03-1997', 'India', '45573637_322114605186763_2497397545592946688_n.jpg', '03/03/2019 ', '0', '0'),
('Rami', 'Malek', 'rami_malek', 'iamrami@gmail.com', '6745', '01934501220', '13-04-1990', 'Egypt', 'default.png', '03/03/2019 ', '', ''),
('Bradley', 'Cooper', 'shallow', 'tellmesomethinggirl@gmail.com', '5678', '01893456789', '12-12-1981', 'USA', 'default.png', '03/03/2019 ', '', ''),
('Shek', 'Safwan', 'sheksafwan', 'safwan96@gmail.com', '1000', '01654448790', '16-12-1996', 'Dubai', 'default.png', '03/03/2019 ', '', ''),
('Barney', 'Stinson', 'stinsonbarney', 'iamlegendary@gmail.com', '9876', '01709377283', '08-10-1991', 'USA', 'default.png', '03/03/2019 ', '', ''),
('First name', 'Last name', 'User Name', 'Email', 'Password', 'phone ', NULL, '', 'default', '03/03/2019 ', '', ''),
('Yepshita', 'Roy', 'yepshita', 'yepshiroy@gmail.com', '7787', '01739673896', '13-11-2002', 'India', 'default.png', '03/03/2019 ', '', '');

-- --------------------------------------------------------

--
-- Stand-in structure for view `user_type`
-- (See below for the actual view)
--
CREATE TABLE `user_type` (
`id` varchar(100)
,`u_id` varchar(100)
,`type` varchar(100)
,`s` varchar(100)
,`valid_till` varchar(100)
);

-- --------------------------------------------------------

--
-- Structure for view `ep_stat`
--
DROP TABLE IF EXISTS `ep_stat`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ep_stat`  AS  select `history_tv`.`u_id` AS `u_id`,count(0) AS `no` from `history_tv` group by `history_tv`.`u_id` ;

-- --------------------------------------------------------

--
-- Structure for view `history_user`
--
DROP TABLE IF EXISTS `history_user`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `history_user`  AS  select concat(`content`.`name`,' ',`season`.`no`,' ',`episode`.`ep`) AS `name`,`content`.`id` AS `id`,`history_tv`.`date` AS `date`,`history_tv`.`u_id` AS `u_id` from (((((`history_tv` join `episode`) join `season_ep`) join `season`) join `tv_season`) join `content`) where ((`history_tv`.`e_id` = `episode`.`id`) and (`episode`.`id` = `season_ep`.`e_id`) and (`season_ep`.`s_id` = `season`.`id`) and (`season`.`id` = `tv_season`.`s_id`) and (`content`.`id` = `tv_season`.`c_id`)) union select `content`.`name` AS `name`,`content`.`id` AS `id`,`history_movie`.`date` AS `date`,`history_movie`.`u_id` AS `u_id` from (`history_movie` join `content`) where (`history_movie`.`c_id` = `content`.`id`) ;

-- --------------------------------------------------------

--
-- Structure for view `movie_stat`
--
DROP TABLE IF EXISTS `movie_stat`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `movie_stat`  AS  (select `history_movie`.`u_id` AS `u_id`,count(0) AS `movie` from `history_movie` group by `history_movie`.`u_id`) ;

-- --------------------------------------------------------

--
-- Structure for view `no_of_ep`
--
DROP TABLE IF EXISTS `no_of_ep`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `no_of_ep`  AS  select `season`.`id` AS `id`,`season`.`no` AS `season`,count(0) AS `no_of_ep` from (`season` join `season_ep`) where (`season`.`id` = `season_ep`.`s_id`) group by `season`.`id` ;

-- --------------------------------------------------------

--
-- Structure for view `no_of_season`
--
DROP TABLE IF EXISTS `no_of_season`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `no_of_season`  AS  select `content`.`name` AS `name`,`content`.`id` AS `id`,count(0) AS `no_of_season` from (`content` join `tv_season`) where (`content`.`id` = `tv_season`.`c_id`) group by `content`.`id` ;

-- --------------------------------------------------------

--
-- Structure for view `user_type`
--
DROP TABLE IF EXISTS `user_type`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_type`  AS  select `staff_entry`.`s_id` AS `id`,`staff_entry`.`u_id` AS `u_id`,`staff_entry`.`stype` AS `type`,`staff_entry`.`submitted_on` AS `s`,`staff_entry`.`valid_till` AS `valid_till` from `staff_entry` union select `payment_netry`.`p_id` AS `id`,`payment_netry`.`u_id` AS `u_id`,`payment_netry`.`purchased_type` AS `type`,`payment_netry`.`submited_on` AS `s`,`payment_netry`.`valid_till` AS `v` from `payment_netry` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`cmnt_id`),
  ADD KEY `u_id` (`u_id`),
  ADD KEY `comment_ibfk_2` (`c_id`);

--
-- Indexes for table `comment_love`
--
ALTER TABLE `comment_love`
  ADD PRIMARY KEY (`cmnt_id`,`u_id`),
  ADD KEY `u_id` (`u_id`);

--
-- Indexes for table `comment_reply`
--
ALTER TABLE `comment_reply`
  ADD PRIMARY KEY (`cmnt_id`),
  ADD KEY `parent` (`parent`);

--
-- Indexes for table `content`
--
ALTER TABLE `content`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `content_genres`
--
ALTER TABLE `content_genres`
  ADD PRIMARY KEY (`c_id`,`genre`),
  ADD KEY `genre` (`genre`);

--
-- Indexes for table `country`
--
ALTER TABLE `country`
  ADD PRIMARY KEY (`country`);

--
-- Indexes for table `episode`
--
ALTER TABLE `episode`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`genre`);

--
-- Indexes for table `history_movie`
--
ALTER TABLE `history_movie`
  ADD PRIMARY KEY (`u_id`,`c_id`),
  ADD KEY `c_id` (`c_id`);

--
-- Indexes for table `history_tv`
--
ALTER TABLE `history_tv`
  ADD PRIMARY KEY (`u_id`,`e_id`),
  ADD KEY `e_id` (`e_id`);

--
-- Indexes for table `hit_content`
--
ALTER TABLE `hit_content`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `hit_season`
--
ALTER TABLE `hit_season`
  ADD PRIMARY KEY (`s_id`);

--
-- Indexes for table `hot_content`
--
ALTER TABLE `hot_content`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `inbox`
--
ALTER TABLE `inbox`
  ADD PRIMARY KEY (`i_id`),
  ADD KEY `u_id` (`u_id`);

--
-- Indexes for table `info_series`
--
ALTER TABLE `info_series`
  ADD PRIMARY KEY (`c_id`),
  ADD KEY `country` (`country`),
  ADD KEY `language` (`language`);

--
-- Indexes for table `language`
--
ALTER TABLE `language`
  ADD PRIMARY KEY (`language`);

--
-- Indexes for table `log_in`
--
ALTER TABLE `log_in`
  ADD PRIMARY KEY (`login_id`),
  ADD KEY `u` (`u_id`);

--
-- Indexes for table `movie_play`
--
ALTER TABLE `movie_play`
  ADD PRIMARY KEY (`m_id`);

--
-- Indexes for table `payment_netry`
--
ALTER TABLE `payment_netry`
  ADD PRIMARY KEY (`p_id`),
  ADD KEY `u_id` (`u_id`),
  ADD KEY `purchased_type` (`purchased_type`);

--
-- Indexes for table `plan`
--
ALTER TABLE `plan`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `rating_content`
--
ALTER TABLE `rating_content`
  ADD PRIMARY KEY (`u_id`,`c_id`),
  ADD KEY `c_id` (`c_id`);

--
-- Indexes for table `season`
--
ALTER TABLE `season`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `season_ep`
--
ALTER TABLE `season_ep`
  ADD PRIMARY KEY (`s_id`,`e_id`),
  ADD KEY `e_id` (`e_id`);

--
-- Indexes for table `slideshow`
--
ALTER TABLE `slideshow`
  ADD PRIMARY KEY (`content_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`type`);

--
-- Indexes for table `staff_entry`
--
ALTER TABLE `staff_entry`
  ADD PRIMARY KEY (`s_id`),
  ADD KEY `u_id` (`u_id`),
  ADD KEY `stype` (`stype`);

--
-- Indexes for table `tv_season`
--
ALTER TABLE `tv_season`
  ADD PRIMARY KEY (`c_id`,`s_id`),
  ADD KEY `s_id` (`s_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`User_name`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `comment_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `comment_ibfk_2` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `comment_love`
--
ALTER TABLE `comment_love`
  ADD CONSTRAINT `comment_love_ibfk_2` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `comment_love_ibfk_3` FOREIGN KEY (`cmnt_id`) REFERENCES `comment` (`cmnt_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `comment_reply`
--
ALTER TABLE `comment_reply`
  ADD CONSTRAINT `comment_reply_ibfk_1` FOREIGN KEY (`parent`) REFERENCES `comment` (`cmnt_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `content_genres`
--
ALTER TABLE `content_genres`
  ADD CONSTRAINT `content_genres_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `content_genres_ibfk_2` FOREIGN KEY (`genre`) REFERENCES `genres` (`genre`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `history_movie`
--
ALTER TABLE `history_movie`
  ADD CONSTRAINT `history_movie_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `history_movie_ibfk_2` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `history_tv`
--
ALTER TABLE `history_tv`
  ADD CONSTRAINT `history_tv_ibfk_1` FOREIGN KEY (`e_id`) REFERENCES `episode` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `history_tv_ibfk_2` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `hit_content`
--
ALTER TABLE `hit_content`
  ADD CONSTRAINT `hit_content_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `hit_season`
--
ALTER TABLE `hit_season`
  ADD CONSTRAINT `hit_season_ibfk_1` FOREIGN KEY (`s_id`) REFERENCES `season` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `hot_content`
--
ALTER TABLE `hot_content`
  ADD CONSTRAINT `hot_content_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inbox`
--
ALTER TABLE `inbox`
  ADD CONSTRAINT `inbox_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `info_series`
--
ALTER TABLE `info_series`
  ADD CONSTRAINT `info_series_ibfk_1` FOREIGN KEY (`country`) REFERENCES `country` (`country`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `info_series_ibfk_2` FOREIGN KEY (`language`) REFERENCES `language` (`language`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `info_series_ibfk_3` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `log_in`
--
ALTER TABLE `log_in`
  ADD CONSTRAINT `log_in_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `movie_play`
--
ALTER TABLE `movie_play`
  ADD CONSTRAINT `movie_play_ibfk_1` FOREIGN KEY (`m_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `payment_netry`
--
ALTER TABLE `payment_netry`
  ADD CONSTRAINT `payment_netry_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `payment_netry_ibfk_2` FOREIGN KEY (`purchased_type`) REFERENCES `plan` (`name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `rating_content`
--
ALTER TABLE `rating_content`
  ADD CONSTRAINT `rating_content_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `season_ep`
--
ALTER TABLE `season_ep`
  ADD CONSTRAINT `season_ep_ibfk_1` FOREIGN KEY (`e_id`) REFERENCES `episode` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `season_ep_ibfk_2` FOREIGN KEY (`s_id`) REFERENCES `season` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `slideshow`
--
ALTER TABLE `slideshow`
  ADD CONSTRAINT `slideshow_ibfk_1` FOREIGN KEY (`content_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `staff_entry`
--
ALTER TABLE `staff_entry`
  ADD CONSTRAINT `staff_entry_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`User_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `staff_entry_ibfk_2` FOREIGN KEY (`stype`) REFERENCES `staff` (`type`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tv_season`
--
ALTER TABLE `tv_season`
  ADD CONSTRAINT `tv_season_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `content` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tv_season_ibfk_2` FOREIGN KEY (`s_id`) REFERENCES `season` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
