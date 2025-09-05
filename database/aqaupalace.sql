-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 05 sep 2025 om 09:43
-- Serverversie: 10.4.32-MariaDB
-- PHP-versie: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aqaupalace`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `abonnementen`
--

CREATE TABLE `abonnementen` (
  `abonnement_id` int(11) NOT NULL,
  `begindatum` date NOT NULL,
  `einddatum` date DEFAULT NULL,
  `type` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `geschiedenis`
--

CREATE TABLE `geschiedenis` (
  `geschiedenis_id` int(11) NOT NULL,
  `actie` varchar(255) NOT NULL,
  `datum` datetime NOT NULL,
  `abonnement_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `incheck`
--

CREATE TABLE `incheck` (
  `incheck_id` int(11) NOT NULL,
  `datum` datetime NOT NULL,
  `abonnement_id` int(11) DEFAULT NULL,
  `locatie` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `rittenkaartsaldo`
--

CREATE TABLE `rittenkaartsaldo` (
  `saldo_id` int(11) NOT NULL,
  `saldo` decimal(10,2) NOT NULL,
  `aantal_beurten` int(11) NOT NULL,
  `abonnement_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_firstname` varchar(20) NOT NULL,
  `user_lastname` varchar(30) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(60) NOT NULL,
  `user_admin` int(11) NOT NULL,
  `user_role` varchar(20) DEFAULT 'standaard'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `users`
--

INSERT INTO `users` (`user_id`, `user_firstname`, `user_lastname`, `user_email`, `user_username`, `user_password`, `user_admin`, `user_role`) VALUES
(1, 'Eva', 'Johnson', 'eva.johnson@email.com', 'eva_j', '$2a$11$BbonybeptV.xVZTjVJARv.kqdV7kHkhyUdPF9B6D2OqhdzOWolA2S', 0, 'standaard'),
(2, 'Liam', 'Miller', 'liam.miller@email.com', 'liam_m', 'Liam#456', 0, 'standaard'),
(3, 'Sophia', 'Smith', 'sophia.smith@email.com', 'sophia_s', 'Sophia@789', 0, 'standaard'),
(4, 'Noah', 'Brown', 'noah.brown@email.com', 'noah_b', 'Noah_123', 0, 'standaard'),
(5, 'Ava', 'Davis', 'ava.davis@email.com', 'ava_d', 'Ava#456', 0, 'standaard'),
(6, 'Jackson', 'Martinez', 'jackson.martinez@email.co', 'jackson_m', 'Jackson@789', 0, 'standaard'),
(7, 'Olivia', 'Garcia', 'olivia.g@email.com', 'olivia_g', 'Olivia_123', 0, 'standaard'),
(8, 'Lucas', 'Williams', 'lucas.w@email.com', 'lucas_w', 'Lucas#456', 0, 'standaard'),
(9, 'Isabella', 'Jones', 'isabella.j@email.com', 'isabella_j', 'Isabella@789', 0, 'standaard'),
(10, 'Mia', 'Rodriguez', 'mia.rodriguez@email.com', 'mia_r', 'Mia_123', 0, 'standaard');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `abonnementen`
--
ALTER TABLE `abonnementen`
  ADD PRIMARY KEY (`abonnement_id`);

--
-- Indexen voor tabel `geschiedenis`
--
ALTER TABLE `geschiedenis`
  ADD PRIMARY KEY (`geschiedenis_id`),
  ADD KEY `abonnement_id` (`abonnement_id`);

--
-- Indexen voor tabel `incheck`
--
ALTER TABLE `incheck`
  ADD PRIMARY KEY (`incheck_id`),
  ADD KEY `abonnement_id` (`abonnement_id`);

--
-- Indexen voor tabel `rittenkaartsaldo`
--
ALTER TABLE `rittenkaartsaldo`
  ADD PRIMARY KEY (`saldo_id`),
  ADD KEY `abonnement_id` (`abonnement_id`);

--
-- Indexen voor tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `abonnementen`
--
ALTER TABLE `abonnementen`
  MODIFY `abonnement_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `geschiedenis`
--
ALTER TABLE `geschiedenis`
  MODIFY `geschiedenis_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `incheck`
--
ALTER TABLE `incheck`
  MODIFY `incheck_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `rittenkaartsaldo`
--
ALTER TABLE `rittenkaartsaldo`
  MODIFY `saldo_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `geschiedenis`
--
ALTER TABLE `geschiedenis`
  ADD CONSTRAINT `geschiedenis_ibfk_1` FOREIGN KEY (`abonnement_id`) REFERENCES `abonnementen` (`abonnement_id`);

--
-- Beperkingen voor tabel `incheck`
--
ALTER TABLE `incheck`
  ADD CONSTRAINT `incheck_ibfk_1` FOREIGN KEY (`abonnement_id`) REFERENCES `abonnementen` (`abonnement_id`);

--
-- Beperkingen voor tabel `rittenkaartsaldo`
--
ALTER TABLE `rittenkaartsaldo`
  ADD CONSTRAINT `rittenkaartsaldo_ibfk_1` FOREIGN KEY (`abonnement_id`) REFERENCES `abonnementen` (`abonnement_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
