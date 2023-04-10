-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2018 at 02:49 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `modernpl_apps`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_apps`
--

CREATE TABLE `tbl_apps` (
  `Row` int(11) NOT NULL,
  `Name` text COLLATE utf8_persian_ci NOT NULL,
  `title` text COLLATE utf8_persian_ci,
  `post_link` text COLLATE utf8_persian_ci,
  `image_address` text COLLATE utf8_persian_ci,
  `app_type` text COLLATE utf8_persian_ci NOT NULL,
  `comment` text COLLATE utf8_persian_ci,
  `gheymat` text COLLATE utf8_persian_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tbl_apps`
--

INSERT INTO `tbl_apps` (`Row`, `Name`, `title`, `post_link`, `image_address`, `app_type`, `comment`, `gheymat`) VALUES
(1, 'تست مقاومت های الکترونیکی', 'برنامه ای برای محاسبه مقدار اهم مقاومت های الکترونیکی .', 'resistance_app', 'resistence_icon.jpg', 'اندروید', 'با استفاده از این برنامه کاربردی ، شما به راحتی و در سریعترین زمان میتوانید مقدار اهم مقاومت الکترونیکی مد نظر خود را همراه با خطای آن بدست آورید .  بدون نیاز به محاسبات و حفظ کردن رنگ ها .', 'رایگان'),
(2, 'اپلیکیشن سلفی راحت', 'برنامه عکاسی توسط دو دستگاه با قابلیت کنترل دوربین .', 'easy_taking_app', '2018_Easy_Taking.jpg', 'اندروید', 'اپلیکیشن عکاسی توسط دو دستگاه به صورت کنترل از راه دور .  با این برنامه شما میتوانید به راحتی دستگاه خود را به عنوان دوربین عکاسی انتخاب کرده و آن را از راه دور کنترل نمایید .', 'قیمت : 9000 تومان'),
(3, 'دسترسی سه سوته', 'نرم افزاری برای دسترسی سریع به بخش های مختلف دستگاه', 'fast_accessibility_app', 'fast_acs_icon.jpg', 'اندروید', 'با استفاده از این نرم افزار ، قادر خواهید بود به راحتی و در کمترین زمان مککن به بخش های مختلف دستگاه خود همچون : قسمت های مختلف تنظیمات ، مخاطبین ، فایل ها و پوشه ها برنامه های نصب شده بر روی دستگاه خود دسترسی داشته باشید .', 'قیمت : 12000 تومان'),
(4, 'ماشین حساب پیشرفته', 'ماشین حساب پیشرفته با قابلیت تشخیص اعداد اول', 'calculator_app', 'calculator_logo.jpg', 'اندروید', 'دارای قابلیت هایی همچون : تشخیص اعداد اول ، ذخیره نا محدود اعداد در حافظه ماشین حساب ، محاسبه فاکتوریل و نسبت های مثلثاتی .', 'رایگان');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_articles`
--

CREATE TABLE `tbl_articles` (
  `Row` int(11) NOT NULL,
  `title` text COLLATE utf8_persian_ci NOT NULL,
  `image_address` text COLLATE utf8_persian_ci,
  `comment` text COLLATE utf8_persian_ci,
  `post_link` text COLLATE utf8_persian_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tbl_articles`
--

INSERT INTO `tbl_articles` (`Row`, `title`, `image_address`, `comment`, `post_link`) VALUES
(1, 'راهنمای ساخت و راه اندازی سایت', '2018_website_icon.jpg', 'در این مقاله شما با چگونگی کار کرد و نحوه راه اندازی سایت آشنا خواهید شد', 'Knowledge_SettingUp_WebSite'),
(3, 'تعیین آدرس دامنه سایت', 'domain_icon.jpg', 'آموزش نکات کاربردی جهت انتخاب دامنه مناسب برای سایت .بررسی موضوعاتی همچون : انواع دامنه ها ، دامنه های ملی و تأثیر آن در سئو و رتبه سایت .', 'choose_domain_for_website'),
(4, 'معرفی مقدماتی سئو ', 'seo_icon.jpg', 'آموزش اولیه و نکات کلیدی سئو ی سایت و بهبود جایگاه آن در موتور های جستجوگر', 'knowledge_seo');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_buys`
--

CREATE TABLE `tbl_buys` (
  `factor_number` int(11) NOT NULL,
  `Status` int(1) DEFAULT '0',
  `ip` text COLLATE utf8_persian_ci,
  `Hardware_License` text COLLATE utf8_persian_ci,
  `Price` int(11) DEFAULT NULL,
  `Date` text COLLATE utf8_persian_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tbl_buys`
--

INSERT INTO `tbl_buys` (`factor_number`, `Status`, `ip`, `Hardware_License`, `Price`, `Date`) VALUES
(123, 0, 'ip', 'hd', 5000, '1396');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_comments`
--

CREATE TABLE `tbl_comments` (
  `Row` int(11) NOT NULL,
  `flag` int(11) NOT NULL DEFAULT '0',
  `tbl_cmt` text COLLATE utf8_persian_ci,
  `Name` text COLLATE utf8_persian_ci NOT NULL,
  `Email` text COLLATE utf8_persian_ci NOT NULL,
  `Date` text COLLATE utf8_persian_ci NOT NULL,
  `Time` text COLLATE utf8_persian_ci NOT NULL,
  `comment` text COLLATE utf8_persian_ci NOT NULL,
  `ip` text COLLATE utf8_persian_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tbl_comments`
--

INSERT INTO `tbl_comments` (`Row`, `flag`, `tbl_cmt`, `Name`, `Email`, `Date`, `Time`, `comment`, `ip`) VALUES
(1, 0, 'art_4', 'sdfgsdf', 'dfgsdgsfdg@fgsdfg.sdfgsdf', '1396/12/1', '21:36', 'sdfgsdfg', '127.0.0.1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_contact`
--

CREATE TABLE `tbl_contact` (
  `r` int(11) NOT NULL,
  `Name` text COLLATE utf8_persian_ci NOT NULL,
  `Email` text COLLATE utf8_persian_ci,
  `comment` text COLLATE utf8_persian_ci NOT NULL,
  `date` text COLLATE utf8_persian_ci NOT NULL,
  `time` text COLLATE utf8_persian_ci NOT NULL,
  `ip` text COLLATE utf8_persian_ci NOT NULL,
  `status` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `tbl_contact`
--

INSERT INTO `tbl_contact` (`r`, `Name`, `Email`, `comment`, `date`, `time`, `ip`, `status`) VALUES
(1, 'فروشگاه اینترنتی بازار 2020', 'info@bazar2020.com', 'با سلام درصورت تمایل به وب سایت بازار 2020 مراجعه کنید و فروشگاه رایگان با درگاه الکترونیک پرداخت ایجاد نمایید ومحصولاتتان را در کل کشور بفروش برسانید. از طرفی سایت دارای مجوزه های لازم از جمله نماد دوستاره الکترونیک هم می باشد و تا زمانی که کالایی به فروش نرفته هزینه ای از شما اخذ نمی گردد. کلیه خدمات سایت نیز رایگان است و ضمنا شما می توانید با درج فروشگاه وثبت کالا وبازدید بالای وب سایت شانس برنده شدن در قرعه کشی واخذ جوایز را نیز داشته باشید .                     www.bazar2020.ir', '1396/7/4', '13:32', '172.252.126.67', 2),
(2, 'علیزاده', 'alizadeh8778@gmail.com', 'سفارش\nand : on\nweb : \nwin : \n\nسلام یک اپلیکیشن آموزشی در زمینه روانشناسی حاوی متون آموزشی، تست (اجرا و تفسیر) صوت و تصویر لازم دارم. با تشکر', '1396/8/17', '9:10', '188.211.41.95', 2),
(4, 'Sina', '09127014775', 'سفارش\nand : on\nweb : on\nwin : on\n\nتست سفارش', '1396/10/2', '16:7', '188.210.179.169', 2),
(5, 'sdfgsdf', 'dfgsdfgsdf@dfgsd.dfgdsf', 'سفارش\nand : \nweb : on\nwin : \n\nadgfasgagwgqwg', '1396/12/1', '21:40', '127.0.0.1', 0),
(6, 'sdfaefwe', 'fqwefq', 'ewfqwefqwef', '1396/12/1', '21:46', '127.0.0.1', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_apps`
--
ALTER TABLE `tbl_apps`
  ADD PRIMARY KEY (`Row`);

--
-- Indexes for table `tbl_articles`
--
ALTER TABLE `tbl_articles`
  ADD PRIMARY KEY (`Row`);

--
-- Indexes for table `tbl_buys`
--
ALTER TABLE `tbl_buys`
  ADD PRIMARY KEY (`factor_number`);

--
-- Indexes for table `tbl_comments`
--
ALTER TABLE `tbl_comments`
  ADD PRIMARY KEY (`Row`);

--
-- Indexes for table `tbl_contact`
--
ALTER TABLE `tbl_contact`
  ADD PRIMARY KEY (`r`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_apps`
--
ALTER TABLE `tbl_apps`
  MODIFY `Row` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_articles`
--
ALTER TABLE `tbl_articles`
  MODIFY `Row` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_buys`
--
ALTER TABLE `tbl_buys`
  MODIFY `factor_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;
--
-- AUTO_INCREMENT for table `tbl_comments`
--
ALTER TABLE `tbl_comments`
  MODIFY `Row` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_contact`
--
ALTER TABLE `tbl_contact`
  MODIFY `r` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
