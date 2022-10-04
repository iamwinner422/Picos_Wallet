-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : mar. 08 sep. 2020 à 20:09
-- Version du serveur :  5.7.24
-- Version de PHP : 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `picos_wallet`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE `categories` (
  `num_cat` int(11) NOT NULL,
  `nom_cat` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`num_cat`, `nom_cat`) VALUES
(1, 'Revenus'),
(2, 'Dépenses');

-- --------------------------------------------------------

--
-- Structure de la table `devises`
--

CREATE TABLE `devises` (
  `num_dvs` int(11) NOT NULL,
  `code_dvs` varchar(4) DEFAULT NULL,
  `description` varchar(85) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `devises`
--

INSERT INTO `devises` (`num_dvs`, `code_dvs`, `description`) VALUES
(1, 'XOF', 'Franc CFA - BCEAO'),
(2, 'EUR', 'Euro'),
(3, 'USD', 'Dollar Américain'),
(4, 'XAF', 'Franc CFA - BEAC'),
(5, 'JPY', 'Yen Japonais'),
(6, 'GPB', 'Livre Sterling'),
(7, 'RUB', 'Roubles Russe');

-- --------------------------------------------------------

--
-- Structure de la table `portefeuilles`
--

CREATE TABLE `portefeuilles` (
  `num_ptf` int(11) NOT NULL,
  `nom_ptf` varchar(65) NOT NULL,
  `solde_ptf` float NOT NULL DEFAULT '0',
  `devise` varchar(4) NOT NULL,
  `num_user` int(11) NOT NULL,
  `date_debut` varchar(10) NOT NULL,
  `date_fin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `portefeuilles`
--

INSERT INTO `portefeuilles` (`num_ptf`, `nom_ptf`, `solde_ptf`, `devise`, `num_user`, `date_debut`, `date_fin`) VALUES
(1, 'Home', 458000, 'XOF', 1, '2/9/2020', '10/9/2020'),
(2, 'Main', 23, 'USD', 1, '2/9/2020', '4/9/2020'),
(3, 'Ola', 46430, 'XOF', 2, '2/9/2020', '8/9/2020'),
(4, 'Lea', 25000, 'XOF', 2, '2/9/2020', '4/9/2020'),
(5, 'Essais', 68630, 'XOF', 3, '7/9/2020', '8/9/2020'),
(6, 'Toto', 1700000, 'XOF', 4, '8/9/2020', '31/12/2020');

-- --------------------------------------------------------

--
-- Structure de la table `transactions`
--

CREATE TABLE `transactions` (
  `num_tst` int(11) NOT NULL,
  `comment_tst` varchar(255) NOT NULL DEFAULT '0',
  `montant_tst` float NOT NULL DEFAULT '0',
  `heure_tst` varchar(6) DEFAULT NULL,
  `date_tst` varchar(10) NOT NULL DEFAULT '0',
  `num_type` int(11) NOT NULL DEFAULT '0',
  `num_ptf` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `transactions`
--

INSERT INTO `transactions` (`num_tst`, `comment_tst`, `montant_tst`, `heure_tst`, `date_tst`, `num_type`, `num_ptf`) VALUES
(1, 'Sans commentaire', 500000, '19:50', '2/9/2020', 9, 1),
(2, 'Payement de la facture d\'électricité du mois de Août....', 12000, '19:57', '2/9/2020', 2, 1),
(3, 'Approvisionnement en Maïs ^_^', 10000, '20:0', '2/9/2020', 1, 1),
(4, 'Achat d\'une montre pour anniversaire', 5000, '20:45', '2/9/2020', 4, 1),
(5, 'Achat de carburant...', 15000, '20:49', '2/9/2020', 3, 1),
(6, 'Sans commentaire', 20, '20:51', '2/9/2020', 8, 2),
(7, 'Paiement de l\'abonnement NetFlix...', 7, '20:59', '2/9/2020', 2, 2),
(8, 'Sans commentaire', 10, '21:5', '2/9/2020', 7, 2),
(9, 'Sans commentaire', 15000, '21:5', '2/9/2020', 7, 1),
(10, 'Sans commentaire', 50000, '21:17', '2/9/2020', 4, 3),
(11, 'Sans commentaire', 3570, '21:19', '2/9/2020', 1, 3),
(12, 'Premier salaire.', 25000, '21:22', '2/9/2020', 9, 4),
(13, 'Retour sur investissement.', 15000, '22:39', '6/9/2020', 8, 1),
(14, 'Sans commentaire', 150000, '15:14', '7/9/2020', 9, 5),
(15, 'Approvisionnement en maïs pour le mois', 10000, '15:15', '7/9/2020', 1, 5),
(16, 'Paiement de la facture du mois', 8370, '15:16', '7/9/2020', 2, 5),
(17, 'Sans commentaire', 95000, '15:16', '7/9/2020', 5, 5),
(18, 'Sans commentaire', 37000, '15:19', '7/9/2020', 7, 5),
(19, 'Sans commentaire', 5000, '15:19', '7/9/2020', 4, 5),
(20, 'Salaire', 750000, '13:36', '8/9/2020', 9, 6),
(21, 'Cadeau de fin d\'année', 1000000, '13:37', '8/9/2020', 4, 6),
(22, 'Achat de deux sacs de riz parfumés', 50000, '13:38', '8/9/2020', 1, 6);

-- --------------------------------------------------------

--
-- Structure de la table `type_transac`
--

CREATE TABLE `type_transac` (
  `num_type` int(11) NOT NULL,
  `libelle_type` varchar(85) NOT NULL DEFAULT '0',
  `num_cat` int(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `type_transac`
--

INSERT INTO `type_transac` (`num_type`, `libelle_type`, `num_cat`) VALUES
(1, 'Alimentation', 2),
(2, 'Factures', 2),
(3, 'Transport', 2),
(4, 'Cadeau', 2),
(5, 'Voyage', 2),
(6, 'Loisir', 2),
(7, 'Prime', 1),
(8, 'Intêret', 1),
(9, 'Salaire', 1),
(10, 'Divers', 1),
(11, 'Cadeau', 1);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `num_user` int(11) NOT NULL,
  `login_user` varchar(70) DEFAULT NULL,
  `pass_user` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`num_user`, `login_user`, `pass_user`) VALUES
(1, 'iamwinner422', '0422'),
(2, 'Test', '1212'),
(3, 'LeeTest', '0000'),
(4, 'Toto', 'toto');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`num_cat`);

--
-- Index pour la table `devises`
--
ALTER TABLE `devises`
  ADD PRIMARY KEY (`num_dvs`);

--
-- Index pour la table `portefeuilles`
--
ALTER TABLE `portefeuilles`
  ADD PRIMARY KEY (`num_ptf`),
  ADD KEY `FK_portefeuilles_utilisateurs` (`num_user`);

--
-- Index pour la table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`num_tst`),
  ADD KEY `FK_transactions_portefeuilles` (`num_ptf`),
  ADD KEY `FK_transactions_type_transac` (`num_type`);

--
-- Index pour la table `type_transac`
--
ALTER TABLE `type_transac`
  ADD PRIMARY KEY (`num_type`),
  ADD KEY `FK__categories` (`num_cat`);

--
-- Index pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`num_user`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categories`
--
ALTER TABLE `categories`
  MODIFY `num_cat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `devises`
--
ALTER TABLE `devises`
  MODIFY `num_dvs` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `portefeuilles`
--
ALTER TABLE `portefeuilles`
  MODIFY `num_ptf` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `num_tst` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `type_transac`
--
ALTER TABLE `type_transac`
  MODIFY `num_type` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `num_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
