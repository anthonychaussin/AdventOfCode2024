﻿using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace AdventOfCode2024
{
    public partial class Day4
    {
        private string data =
@"XSXMAAXXSSMMMXMXSXMSXMXSAMXSXMASMMSSMMSASXSAAXAAMXMMAMAMXMXSMXSAMXAXSAMXSSSXMASAMXAAMXSXMASAMXXMAXXSAXAMXMMSAASMXMXMASMMAMXXXSAMMSMMSXMASXAA
XXAMMSMMXMAMAASXSAMAMSAMASASMSASAAAAAXSASAMMMXSMXSAMSSMMASMSAAXXSXAMSAMXMMXMSAMXXXMSMAMMAMXMSSMMMSSMMSASMSXAMMMAASMASAMXSSXSASMSXMAMSASXMMSS
SSSMAAXAAXAMMXSASXMAMMASAMXSAMAXMMSMMMMAMXMAXXAAASAMAAMSMSAMMMSMXMSAXASXSAAMMXSAMXMAMMSMXMAMAAMXAXAAASXMAMXMXAMSAMAXMASAXAXMAMXXAMMMMAMASAMX
XAAMSSSSMSSXSAMAMAMXMSXMASAXMMAMXMXMMAMAMXSAMSMMMSXMMSMAAMXMMXSAAAMSSXMAMSMSAAXAXASMSAMMAXMMSSMMMSMMMXAMSMAXSXMMAMXXXXXMMMMMSMMSXMASXSSMMSXM
MSMMAXXAAXAAMXMASAMXASXSXMASXSXMASXAXMAXXXMMMMAAAXAMXMMMSMAMXAXXMSXAMXMXMAMMMMSMSMSXMAMSSSXAXAMAASAMSSMMASXMAMXSAMXSMSMXAXAAAAXXAXAMAMXXXMXX
XMASMMSMMMMMMAXAXMSMMSAMXAMXXASMAMMMMSSSMSSMASXMMSSMAMAMAXAXMSSXMXMMMXMAMMSSSXMAAAXXSMMSAMMXSMMMMXAMXAXSMXXXXAMXAMAMAAASXSMMSSMMMMAMSXAMAMMX
SSMMMAMXAAAAXMMMSMXAXMAMXSXMAMAMASAMXXAAAAAMXSAAXAAMMSMMMSSSMAAXSAXMAXXASXAAMAMSMMSXMAMMAMXXMXAXMSSMSSMMASMSMSSSXMAMSMXAMAXAXAAASXSAXMASASAM
MAASMSMSSSSSMSAAAXMAMMXMAXAMXXMSASASMMSMMSSMASXMMSSMAXMSMAAAMMSMSASMAXSMMMMSMAMXAASMSAMSSMMXMASMXAAXAXXSMSAAAXAAASAMMXMASAMXSXSMSAMMMAXAMSMS
SSMMAAAAAXXAASMSMMMSMSSMMXAMAMXXXSMMXAAXMMAXAMMSMAAMSSMAMXSMMMXMXAMMMXSXAAXAMAXSMMXAXSXXXAXASAXMMSSMMSMAXMXMMMMSXMASMXSAMASMSAMXMXMMASMMASMM
AAAMXMASMMMMMMAAXAAXAAXAMSMMASMMMMASMSSSSSSMXSAAMASAAMXASMAMXSASMSMXXAMMSMSAMXXSXSMSMMMSSSMXSAMXAAAAAXAMXMAXSAMXXSAMMAMXSSMAXMASMSXSMXAXAMAS
SSMMXSXMASXAAMSMMMSSMMMXMAAXMSXAAAMXAXAAMAAAXMXMSXMMXMMMMAAMASASAXMSMASMMAXMSMMMAMAXAAXMAMMAMXMMMSMSMMMXASXMSASAMXASMMMAMXMXMSMSXSASAXXMXXAM
MMMMAMASXMASXXASXAAXAASASMSMASAXMXXSMMMXMSMMMASXSXSAMXASXSSSMMMMAMAMMAMMMSMAAAXMAMASXMSMSMMASAMMMXMMASXSXSMASXMAXSXMAAXAAMSSMMAXAMAMSXXASMSS
MAAMASAMAMMMMSASMMMSSMXASAAMSMMSMSAMMAXXMXXASAMAMAXAMSAMAAAXXAMMMMXMMMSXAMMSSSMXXSAMAASAAXSAMAMSASASAMXAAMMAMAMXMSSSMMXMXAAAAMMMMMXMASMAMAMA
SSMSXMASASAAXMAMXAMMXAMSMXMXMAAAAMXMMASMMMSMSAMAMXMXMMAMMMMSSMMAASASAASMMSAAAAXAMMMSMMMSMMMAMSMMASXMASXMMMMXSXSXAMASAMASXMSSMMSAXASMAXMAMAMX
MMMXXMASASMMSMMMSMSAMXMMAMXASMMMXMAXXXSASAAXSXMXASMMXXXMSAMXAMMXMSAMMSMAXMMMMMMMSAMAMXXAXXMXMXAMXMASMMAXSAMXMAXAMMAMXMAXAAAXAXMAMMXAMXMXSXXS
MAXMAMXMXXASXAXAMMMAMMMMAMMMSXAMAXSSSMSAMSSMMSXMXAAMSSMXSASXMMSXMMMMXXMSMMASAXAASXMAXSAMXSSMMSAMXSXSASAMXASMMAMAXMXMMMMSMMMMMMXAMXXXMSXAAMXS
SAXSAMXAMSXMSMMSSMSAMAAXAMXAXMSXSAAAMAMXMAXAXMXAXMAMAAMMSAMXAASASAXXASXMAXAMMXMMSXAXXAXXMMMAAMMMXMAMAMAMXXMAMASMSSSMSSMAMMSAAXMMXXXAXXMMXSAX
MAMSAMXMXMAAAXMXAASASMSMMSMSSXMAXMMMMSMAMMMMMMSMMSAMSSMAMXMMMMMAMXSMAMASMMMMMXMXMMSMMMSMASMSMSSSMMAMAMAMMMXSSMSAAAAXAASMXAMSSMAMSAMXMMMSAMMS
XMMSAMXMASXSMSMXMMMAXAMAAAAMMAMXMXSXXASMMMASAMAAXMAXMAMMSMSMSSMAMAMMSMMMMXXAXAXAAAAAAAAXXAAMAMAAASASASASXXAMAMMMMMMMSMMMMMXAMMXMAMAAAAAAAMXS
AMXXMAXXAMMAXAMASMMSMAMMSMSMSAMMMASMXMASXSASASMSMMSAMMXSAAAAAMMMMSXAMMSASASMSMSMMMMMMSSSSMXMAMMMMXASMMMSMSXSAMMXXAXAXAAAAXAMXSMMXMSSSMSSSMAS
XXAASASMAMSSSXSAXAAXMXMXMMMASASXMASAAXAXMMASMMAMMAAASXXSXMMSMXAXAAMXMASAMASAAAMMSSMXMXMAAXSSXXXAXMXMXSAMAAASASMMSSMSSMMMMSSXAMAAXMXAAAAAAMAM
MMSXMAXMXMXAAXMMXMMSAMXASXSASAMMMASXSMXSAMXMAXSAMXSSMAMMSMAMASXSMXAXMXMMMMMMMMMAAAMMMAMSMMXAASXMMSAAAMAMMMMMMXAAXASAMXXXXAMMMXAMMMMXMMMXMMAS
AAXAMMMMMMMMXMASAXXAMXMASASAMAMAMAXMMAAAMSSMMSAMXAXMMMSAAMAMXMAAXAMMXMAMXXAAXXMMSSMASAMAMMMMAMAAASMSMSXMMSAMXSMSMMMMXSSMMMSASAAXAASMSMSAXXAM
MXXAMMAAAXAXXMAMMSSMMAMAMAMMMXMMMXSSXSMMASAASAMAMMSAAAMMMXMXAMXMMSSMMSMMMMSSXSAMXAMMSASXMAAXXSSMMSXXAMAMXMASXMAAMAAXMAMAAXSASXSSSXSAAASASMSS
XSSMMSSSXSAMMMSXMAAAMXSXMXMMAXXXXMXMAMXXXMMMMAXXSASMMSSMMASXMMAMXAAAASAXSAMAASXMSSMMSAMMSXSSMMMAMXMMSMXMAMSMAMSMSSSSSMSMMMMAMAMXMSMMMMMAXAAX
MMASMXXAXMASXAMXMSSSMMMAMXMAASMMSXAMAMXXSSMSMSMMMASMAXAAMAXAAASMMSSMMSAMXMMMMMAAAAAXMAMMSAAMAXMXMXMAAAXSXSMSAMXXXMAXXAAMMAMXMAMAXXMAMAMXMMMS
MSAMMSMSMSMMMMXAXMAXMASAMASMMSAASXMMMMSAMMASAMSAMSMMMSAMMSSMMMXAAAAAXMXMSMAXASMMSSMMSMMAMMMSXMSMSAMMMSXMSAMXXXXMSAMXMSMSXXMASAMXXMSSSMSASAMX
MMASXMAAAAXXAMSSMMMMSASASXSAASMMMMXAAAMAMMAMMMSXSAAAAXAMAMAMXXSMMSAMXAXMXSAMXXXAXAMMAMMSXSASXAAASMSSXMASAMSMMMMXSXXXAAAMMMMASASMSMAAAAXAMXSS
XMAMAMSMMMSAXMAMXXAMMAMASMSMMSAAAXSMMMSMMMXSMASMSMSMSXXMXSAMXXMXMAXMMMMMAMMSSSMSSMMSASAMSMASMSMMMAAXASMMXXAASXAAMMMSSMSMASMMSAXAAMMSMMMSMSMM
SMSXMMMXMSMMMMMMAMSMMSMMMAXMASMMSMXAAMAMXMASMASASAMXMAMXASASMMSAMAMXAAAMASXAAAXAAXMSAMXXAMXMAXMSMMMSMMMMMSASMMMXMAMXMAMXAXAXMMMSMMAMAAAAMAAX
AXXASASAMAAAXAAAAAXAAXAXMMMMXMAXXAXMMSASAMXSMMMXMAMASXAMMSMMAXSXSSSSSSSSXSMMSMMMSMXMASMSMSXSXMXMAXMAAAXXAAXMMXAMXXMXMAXMSSSMAAAMAMASXMSMSSSM
MMSMMASMSSSMMXMSMSXMASXMXMASASMMMMSMASASASASASXSSXMASAMMXSMSSMMAXAAAAAAAMXMAXXSXMAXMXAXAAMAMAASASXSSSMSMSSMMXMXSAMSMMASAAAMSSMMXAMAXMXMMXAAX
XAAAMMMAAXMAXSAAAXAMAXAXXXAMMSAAXAAMXMASXMASAMAMAMMXXAXSAMAAXAMAMMMMMMMMSAMXMASASMXXMMMMSMAMSXMAMMAMXAMAAMAXXAAMMMAAXMAXMMMXMAMSAMXSMAMMMXMM
MSSSMAMMMXSAAMSMMMXMASMMMMSSXMMMMSSSXMXMXSXMAMAMAXXAMSMMASMMSSMXMAAAAAAXSMXMSXSAMXSXMXAAAMXMMAMSMSSSMXMMMSSMAMMSXSSSMMSXXXAMMAMMMMXAMASAXMXM
XXAXXASMSXMXSMXXXAMAMSXAAMXAMXASXXMAXMMAMAMSAXMMXMMMXXASXMAXXMASXSMSMSSMMSAMXAMXMAXAMSMSSSMSSMMAAMAXMASXMAMSAMXMAMMAMAAMXMAMMASXSXSMMMSAMSAS
AMAMXMSXMASXMMSMXMSAMXXSXMSAMSXSASMASXAAAMXSAMSASASXMSAMXSXMXMSMAXXMXMMXAAXXMAMXMMSMMAMAAXXXASXMSMXMASXAMAMAXMAMAMSAMXSSSXMASMSAMXXAAMMMMSAS
XMASAMXMXMMXMASAMAXAXAMMMMMAMXAMASMAXASXSXAMMMXAXASMMMSMAAAAAMMMAMAXXSAMSMSXXAXMAXAMXAMMSMMMAMXMAXSMMXMXSSSMMSMMXMMASAMAMXAAXAMAMAMXMSASMMMM
ASASAMMMAMXXMMMXAMMSMSXSASXSMMAMAMMSSXMAAMXSSMMMMXMAAAAMASMSMSAMMSSMAMMMMAMASMXMSSXSSMMMMMSAMMXSMSXAAMXAMMAXAASMSMSMMXMAMSMMSSSSMXSAAMXMAMXX
MMASAMSXMMMXMSMSSXAXAXASXMAAASMMXSAAXAMSSMAMXXAMXXXSMSXSAAAAASXSAAAMXMSAMAMAMXAXMAXXASAAAAXMMMXMXAMSMSMMSSSMSSMXAAXXXSSXMXAXAAAXMASMMMMSXMSS
XMXMMMMASXSXSAAAAMMSAMXMAMSMMMXSAMXSMXMXAMXMASMSMMMMAMAMXSMMMMMMMSXMXSMMSSMXSMXMMXMXAMSXMSSMASAMMAMXASAMXAAAXMXSMMMMXMAXSSSMSMSMSAMXASXMASXA
XSAMXSSMMAAXMMMMSAAAXXAMAMAAMXXMASXMASXSXMAAXMMAASXSAMXMXAMXAXAAXXMSMXAAAAAAMMSXSASMMMAXSAMXXMASXSSMMMAXMSMMMAAMMAAMMMSMXAMAMAXMMMXSAMAXMMSM
MXMXMAAAMMMMMSAMXMSSSSSSMMXXMSAMXSXMSMMXMSSSMMSSMMAMXMXMSXMSMSSSMMAAAXXMSSMMSMAAMAXXAMASMASXXSAMAAXMMSSMAMXMMMMSSSSMMAMXMXMAMMMSAAMMMSXMAAAX
MMMAXMSMMMSAAMASXMAMMAMXMASXMSAAAXMXMXMXMAXAMAAXAMXMAMAAMAMMXXXMMMSMMMAMXMAMAMMSMMXSXSMSXMMAMMAMMMMXASXMAMMMASXMAAAMMASASXMMSMAMXMXAAAASMSSS
SASMSAXMAAMMXSAMAMMSSMSAMXAAASAMXSMAMAMASMSSMMSSSMMSSSMXMAMAXXAXMXAASXMMASAMMXAXAXXMASMMASMXMXAMAAAMXSXSASASASAMMMMSSXSASAXAAMMSASMMMSMMAMAM
SMSAXMAMMXSAXMASXMXMAASXMASMMMXSAMMASASASAAAAXAXMAMXXAASXSMMSSMMSAMXMAASASXSXMSSMMMSAMASAMXAMSMSSXSAXMASXSXMASMMMXAMXXMASAMSMSASMMSAMXMMXMAM
MXSMAXSXXAMMSMAMXMAMMMMAMAMXMSAMASMMSXXAMMMMMMSMSAMSMMMAAXAXAXMAMMXSSSMMAMXAMXAAAAXMAXAMAXMXXAMXXXAMAMAMXMAMXMAAXMSSXMAXMAMMAMASAMSMMSMXXXAM
MAMXMSXSMAMMMXAXAMMMMXSXMAMMXMAMAMXAMXXXSASXMAXASAXXAAXMMMMMSSMXSXAXMAASAMAXMMXSMMSSMMASAMSSMAXAMMSMXMXSMMSXMXSMSXXAXMXXMAMMMMAMXMXXAMMAMSAS
MASAMXAMSSMMMSXXMXSASAMXMAMXXXMMSSMMASAASMMSMXSMMSSSSMSXMAAAAAAAXMASXSMMASMMXXXAMXAAXSAMAXAASMMMAAAMAMMMMAAASMMASMSMMMSMSMMAXMXMSMMMSSMMMAMX
SASAXMAMAMAAAXMSMAAAMXSAMXASXMMAAAASASMXMAAXMMMMAXMAMXMASXSMSSMMXSXAMAXXAMXMASAMXMMSMMASMMSMMSAXSSMSASXSMMSSMASASAAXAXAAAASMMMXXSAMAAAMSMASM
MASAMSMMMSSMXXAAMXSMMMMAMXXAAAMMSSMMASXMSMMMXAXMASMAMMMXMMAAXXAMASMXSAMMSSMMASMMXSMXMMMAXXMAMXXXXAASASMAXAXXMAMAMMMSMXMSMMAMSMSXXAMMSXMAAXMM
MAMAMSAMXAAAAMXMSMXAXXSAMXMAMMMAAAAMXMAMAAMSMSSXXXMAXXXMMXMXMMMMASAAMASAAAXMASASAMMAXAXMASXSMMSSMMMMXMASMXSASXMAMAMAXAAAMXMAAAAXSSMMMASXXMXX
MMSMMSAMXSMMMSAAAASXMXMASAASMSXMSSMMSSMSSSMAAMAMSXSASMMSMSMASAMXMMMMSXMMXSMMASXMAMSAMXXSMXAAXXAAMMMMAMSMMXSAMXMAXMSASMSMSAXXMXMXAMAAXMMASXXS
MMXMASAMXMASASMSMMSMSSSMMXSMAMAMXXMAAAMMAMXMMMAMXAMASAAAAMSAMAXMMSMMMXXAAXAMAMAXAMMMMSAXXMSMMMMSMAASAXAASAMXMASXSAMXSAMASASXSMXMASMMXAMXMXAA
SAMMMSAMXSAMXXAXXAXAAAASXXXAAMMMMAMMSSMMAMXMXSXMMMMAMMSMSMSSSSXSAAXAAXMXMSAMSMSMAMAAAMXMAMAAXXAXMSMSSSMSMXSAMMSXAXXXMXMASAMASMASXMMXAMXSMMAM
SAMXXSAMXMMSMMSMMMMMMSMMMASXMXXAXAMXXAXSXMASAMXSAXMXSAMAMXMAXAAMSMSMMSMMMSMMXAXSMMMMMXASMSMSMMXMAXAMXMXAAASASXXXMMSMMSSMMAMAMMXSMAAASXMAMAAM
SAMSMSAXMAXAAXXAMXSXAAAXMAMXAXSXSASXSMMSASASASAMSSXAMMSAMSMXMMMMAXXAXAAAMMAMMXMAMXAASXMSAAAAXXXMASAXAMSMMMSMMMMMXAXAAMAASXMAMMXMXMMMMASMXSMS
SAMXAMXMMMSMSSXXMAMMXXMMMXXMSMAAMAMAMXASAMXSXMASAMMMSASAMXAXSXSMSMSXSSMSXSAMXASAMXMMMAAMXMSMMXMAMXMMAXMAMMXAASASMSSSMSXMMMSXMSAAXXMASAMMAMAM
XAMXMMSSMMAMXAXSMSXSASMMSAXSAAMXMAMAMMXMAMAXMMXMMSAMMMSAMMMMMASAMXXMAAAMAXAXXMXAMSSSSMMMMMMXXMAAMAXMXMSAMSSSXSMSAMMXXSMMAXAAASMMMXSAMXMMASAA
XXXAXSXAASMMXSMMAMAMAXMAMMMSASMSSMXSMSASAMMXXXAXXMAXAASXMAASMAMAMAXASMMMASMMSSSSMAAAXXMXXAAAMAXAXXSMSAXXSAMXMMXMAMAXXMASMSMMMSAXSAMASMMMMSMM
MSAMXAMMMMAMXXAMAMXMXMMAMMMSAMXXASAAASASXSXXMSMSAAMSMMSMSASMMMSAMSSMAXXXXSXAXAAMMMMMMXSMSMXSASMSMAMMMSXMAXXMASASAMXMMSAMXXXMAXXMMASAMMAAAMAX
AAMMXMSSMSAMXSSMSSSXMMSMMAMMMMAMAMMMMMAXMAMAAAXMASXAMMMXXXXMXXMAAMAXMSXSAMXSMMMMXXXXMXMAAAAAMXAMAAXAAMMMMMMMMSXSXSAXMAMSXAMXSXAMSXMMSXSSSSMM
SSXSMXMAASMSXMXMMAXSAMAMSMSASXSMSXXXAMXMXAXMSMASAMXXXAMMSMSMSXSMMSMMXSAMXMAXASMXMXMMAAMXMMMSXMMMXMXMMSAAAMXXXXAXAMMXXMSMMMMAXMMXMXMASAMAAXXA
XMAMAAMMMMAMAMXSMXMXMMAXAASASAXAMXMXASMMSSMMAXXMASASMMMAAAAAXAXAAXXMAMXMAMASAMAAMAAXSASXXSAXXAXSASXAAXXSSMMAMXAAMSMSMMAXAAMXSAXMMXMAMSMMMMMS
MMMMSXSXMAMSAMAMMSMXMSSSMXMMMXMMMASAMXAAAAMMSMXMAMXMASMXMSMSMMMMXMASAMASASAMXMSSSMSXMAXXASXSXSASASMSMXXXMAASXAMSXAMAASASXSSSMXSAMAMMSXXMAMAX
XSXAXASAXAXSXMASAAMAMAXAXMAMASMXSASASXMMSSMAMMSMXMAMXMSAAXXXAMASAMXASMAXASMXAXAMXMXAMXMMAMAMAAXMAMAXXXXAMXMMAMSAASMSMMMSAXMAXASXMAXXAMXSASMX
AXMMSMMMMXMMXMMMMMSASMSMMMSMASAAMXSXMXSAMXMAXAAXMSSMMAXMXMASAMSMMSMAAMXSXMMASMMSAASXMASAAMAMMMMMSMMMAMXAMAXSAMMMXXAXAMMMMMSMMMSASMSMASASXAXX
SSMXAMAASMMSAXAXAMXXSXAXMAMMAMMMSAMASMMMSMSSMMMMMAMAMXXXSAMSSMXMSAMAMXAMAAXMAAXSXMAAXXXSXSAXXAXMAAXMAXSAMAMMMXAXMMSMMMAAAXAXAXSAMAMMMMASXMXS
AXMAMSSMSAAAMSSSMMSAMXSMMXXMASXAMASMMSAXSMAXMASXMASXMMMSAMXMAXAMMASMXMMSMMMXMSAMXSXMMMMMMSMXSXSSSSMMAMSXMXSASMMSAXXAASXSXSAMXMMAMXMAXMXMAMAS
MSSXXAMXMMMMMMMAAAMAMAMAMMMMXMMXSMMAASXMSMSMSASAMXSXAAMMMMASMMSSMXMMAMXAAAAXXXAAASMMSXMAAMMASMMXXAAMSMSASAMMSAMXMXMMMMAAXXMXAXXXMASXSAMXMMAS
XMAMMMSXXXAXASMMMMSXMASMSAAXSXAAAMSMMMSAXAXAMMSAXMMXSXXAXSMXAAAAMAAXAMXSSMSMASXMAMAAMASAMSMASAXMMSMMMASAMXXMMMMMMMMSSMMMMSSSMMAMSMSAXAAXXMAS
XMAMAAMMMSSSMMAMAMXMMXSASMMSAMMSSMXAAXMSMXMASMXMXASMMMSMXASMMMSSSSSMMXMAMAAMMMMSSSMMSMMASXMAXMMMXAAAMMMAMAMSMSAXXXAASAMXAXAAMSMMAXMXMSMSAMXM
XSASMXSAXAAMASMMASAMXAMXMASXMXAXAXSMMSAMXXSMMMAMSMSAAAAXSAMSAXAMAAXAAMMAMSMXAAAMXAXMAMXXXXMXSSSMASMMSXXAMAXAASXSMMMSSMMSSMMMMAAXXMMMMAAXXMSM
MSASAXSXMMSMAAASMMASMXMAXXXAXMMMMMXAXXMXSXMMASAXXASXMMSMMAMSXMASMMSMMMMXMASAXMSSSMMSASMMMMMSXAAXAXAAAXXSSSSMXMXSAAMAMAAMASAXSASMSAMASMSMSMAS
MMMMMXMXMXXMMSMMMMAMMASMSAMXMMSASASMSASAMXXSASMSMMMSMAXAXAMXMXXMXXXXXSAMXMXSAAMAXXMSASAAAASAMSMMMSMMMSXAAMMXAMMMSSMMSMMMSMXXMXMAMASAMXAAXSAS
MAMAMASASMXXXAXXAMAASMAMXXAAMXSASAAASAMAMSAMXSAMAAASMSSMMMXAAXXASMSAMAXXXXAXMMMMMXAMAMXMXXAAMAAAAXAAAAMMMXSSMSMAAMAXXMSXXAMSSMSSSMMAMSMSMMXS
SASASXSAXAASMMSSXSSMXSAMMMMASAMAMMMXMASXSMXMASASAMXSAASAASXSMSMAMAAXXAMSSMMSXMAXMMMMXMASMSSSSSSMSXSMSSXSAAMXAAMMMSMMMMMXMAMAAXAAXXMAMMAAAMMS
SASAAAMXSMMMAAAXMMMMMMXSAXSMMXSMMXXXSAMMAMXMASAMXSXMMMXMMSAAASMAMXMXMMSMAAAXMMMSAAXSMMMAAXAAAAAMMMMMMXAXMSSMSMSMMMMAMASMMMMXSMMSMMSSMSSSSMAX
MAMAMXMXAXSSXMMSSSMAAMSMMMASAASXMXSXMASXMMXMAMXMMAMSMMSSMMMMMMMAXASAAMAMSMMMMAXSMMXAAAXMXMMMMMMMSAMMSMSMAAMMXXAXMASMMAXAAAAXXXMAAAAXAAAXXMSS
MSMSMAMXMSMASASAMXMMXMAAAXMMMSMAMXMAXAMXXMSMASAXMAXAAMAAXSASAMSMXASMMSAXXAMAMSMMSSMSSMSXSXMXMXMASAXMXAAMMMXMASMMSAMXMSXXMMSXXAMASMMMMMSMXMAM
MAAMAMXAXAXMAMMMSMXMXXMSSSXXXAXAMSAMXSAMMSMSAXXSXSMSSMSSMAMMAMASMAMMMMMMSAMXXMAAAXXAXXSMAMMASMMMSAMSMMMSMMMXMSXMMSXMAMASXMMMSSMXMAAXXMAMSASX
SMSMXXXASMSXXXAXAAAXMSMAMMMSSMSSSXMXAXAMXAAMXSXMAXAAXAMXAMXSXMAXMAMXAAMXSAMXMSMMMSMMSXXMAMSAMAAAXAXXAAAXAMXSXSAMAMXSAMXMAAXAAXMAXSAMXSAMMAMX
MAMAXMMMAXAXXSSSMSMSAAMAMAAAXAAMMMAMXSAMSMSMXAASAMMMMXMASXMAMMXMSMSSSSMAMASAMAXAAXAASMSMAXMASXMSSMMSMMSSMMAMMSAMXSXMASMSMMMMMSSSMXASAMAMMXMM
MAMAMAASAXMMAMAMXMAAMMSSSMSSMMMSAMXMMMMMXAAAXSXMASXSAXSXMASMXSAMAAMAAMMSMAXAXSSMXSSMXAAMXSSXMXXXAMASAAAXXMASASAMMAASXMMSAMXSXAAAASMMASAMMSMS
SSMMXSMSMSMMMMASAMXMAXAAAAMXAMASMSASAMASMSMSXMASXMAMSMMAMMMXASXSMSMMMMAAMMMSAAAMAMMXMSMMMMXMAMXSSXASXMMSXSSSMSAMAMMMAAASAMAMXMSMMMASAMASXAAX
MMASMMAMAMXAXSASASMXXMASMMMSSMAXMMAMXSASXXAMMXAXAMXMAMSSMSAMXSAXXXXMMMSSSMAXMSSMASMSMXSAAMAMAMXXAMXSASXSAXAMXSAMSMASMMMSMMXMAXAXAMXMASAMXMMM
XSAMAMAMSXSXXMASAMXMSXMXMAXMMMSXSMSMMMMXMMSMAMXSSMSSMXAMAMSXAXMASXMSAAXAAMXMMAMMXSAXMAMXMSASASXMMAMSAMMMMMSMMMXMAMASASASXAXSSSMSXSASMMMXAMAA
AMAMSMMMAASMXSASXXSSMASXSMSAMXXAMAMSMASXXAAMAMAAAAAAMMMSXMXMMMMMMMASMSMSMMMSMASXMMMMMMSAASASMSMAXMXMXMAMSAMAMXSSXXMSXMASMSXMMAAAASMMAXMSMSMS
XSAMXAXAMXMAXMASAXSASAMXXXMXMASMMMMXSAMAMXMMASMSMMMSMMAAASXAAAAAAXXXAXXMAMSAMAXXAAXXAAXMMMXMASASXMMSMSMSMASXMAXAXSAMMMSMXMASMMMMMMASXMMAXMAM
XXASXMMSXSMSMMSMMMSAMXSMMASAMXXSAAMMMMSSMASAAAAMXMXMAMMSSMASXXSSSSSXXSMSMXSASASMMMSMMSMMASAMAMXMAMXAXAXXMMMXXXMAMSAMMSMAXSAMXAMXSXMASXMAMSAS
MSMMASAMSXAAXXAAAXMXMXAXXMAMMAMSMXXSMAAAMASAMMMMXAASXMAMAMMMSMMAMXXMMMMAMASAMXSAAAAAXAASAXAMXSMSAMSMMSSMASMMSMMMMSAMXASMMMXSSSMMXMXAMMASMSAS
MAAXAMAXMMXMAXMMMXMASMMMSMAMMAMMSMASMMSSMXSAMXXMMSMSAMXSMXAAXMXSAMXXAAMAMMSAMASXMSSSMSMMASMMMMXMAMAAAAXXAMAAXAAMMMXMMXXXMXMAAMXSAMMXSAMMAMAM
SSXMXXMASMSSSXXASASASAXAASASMMMAAMXMAMMAMXSMMXAXXAASXMAMXSMSSSMXAXMAMMMSMXXAMXSXMAXMMMAXAAAAAMMMMMSMMSMMMSMMMSASAMSSSMSSMMAMXMASAMAAAXMMSMAM
XAXSMSSMXAAAMMSXSASASAMSMSMSASMSSSMSXMXAMMMMSSMSSMXMXSXSASXAAMASMMSMMSAXMMSXMXMASMMMSSXMASMSXSAMSAMXAMXAAMASAMMMASAAAXAAASXXSMMSMMSSMXXXXSXS
MSMXAAAXMMMMMAMMMAMAMMMXXSXMASAAAAMMAMSSMMAAMAXAAXAXXMAMASMMSMXMAAAAAMASAAAAMMSAMAAAAMAMXXAAMXXAMXMMSMSAMSAMAMXSMMMSMMSSMMSMXMXMMAMAXAMAMXMS
MASXSMMMMAAAMSSXMAMXMASXAXXMAMMMSMMSAMXAASMSSSMSSMSSSMAMMMAMAXASXMMMMSAAMMSXMASASXMMSSSMSMMMMAMMSSXSAAMAAMMSMMAXAXXXAXXAXAMXAMAXMAMXMXMAMAAX
SASMMMAASXSMSAAMSMSMSASMAMMMMSAMXMASMSSMMMAAAAAMXAXAXXAMASXSAXMXMMXAMMXSAMXMMMSAMXMXAAXAAAAAMAXSAMXSASMMMAMAAMXSMMSSXMSXMXSSMSSSSMSSSXSASMSS
MASAXMMMSXAMMMSMSAAXMAXAXXAAAMMSAMASXAXASMMMSMMMMXMAMXSSMSAMXXSAMMSMSMAXAXMASAMMMAAMMMMMSSMSXSSMASAXMMXXMASMSMMMMAXAAMMAMXXAAXMAAAAAMASAMAAM
MXMXMASAMXXXXXMAMSMMMSMSXSSMMSASMMASMASXMASXAAAMMMSSMAXAXMAMAMMAMAASAMXXMSSMMMXAMXXXXXXXAMXXAMAXAMXSMSXSSXMAAAAXXMXMMMSAMMSMMMMSMMMSMAMAMMMS
MMMAAMMAXXSSMSMXMMSAXMAMAMAAAMXMXSXXMMXXSSMSSSMSAAXAMSSMMSAMASXSMSXSXSXXMAMAMSMSSXSAMXMAASAMXSAMXMAAAAXMMAXSSSMSMMSMMXMAAAXAMXMAMMXMMMSSMMMX
XAMXSMXMMAAAAMMAMMMSAMAMAMMMMMSAMMAXSMMMMAAAXMAMMMSAMXAXAXASXSAXAMXSAMMAMAXMMSXMAASXAAMAMMXSAMXMMMSMAMSSMMMMAXMSAAAASMSMMMSMSMSSXSAAMAAAAXXM
SSSMAAASMSMMSMMASAAMMSASAMXAMXAAAMSMXAAAXMMSSMMSAMXMXSMMMMXSAMXMMMAMAMXXAMXMAMAXMMMMSXSASXAMXSXXAAMXMXAXAXAMXMASMMSSMAAXSMSAAAMAASXMMMXXMMMX
AXXAMSMSAAMAMASASAXMASXSASMSSXSSMXAAXSSXMXAMMAMSASASMAMASMMMMMMXMMAMMMSSMSAMASXMXAXMXMMAMMXMMAMMMXSASMSSXSSSMMMXMXMXMMMSMAMAMSMMMMMSXSSMSAMS
XMASXXXMMMMASAMXSASMASAMAMAAMXMAMSMSMMAMSMMSMSMMASASMXMAXAAXSAAASMMXXAXAAAMSASAMSMSAMXSAMXXXMXXXAXSAMAAMXXAAXSMAMAMMXXXMMSMXMXXXAXAXAMAMSASA
XMXMXMXSXXMXSXMAMAMMMMAMXMAXMASAMSAMXMAMMAMXXXAMXMAMASMASMMMSASASAAAMSSMMMXMMSAMSASXMAXMMSSXMSSMMMMMMMMSMMSMMAMMSMSAMSSMAXASXXSSMSSMMMAMXXMA
MSAMASAMMMMAXASXMXMAXSXMXASXSAXMSMXMMMMXSAMMXSAMXMXMMXMAXMAXXMMASMMSXMAMAMAMMSAMMAMXMMXSAMXXSAMXSMAXXXMAXAXASMAXAMXXMAAMASAMXAMAMAMAXSMSSMAX
ASASAMASAAMAMXAXMAMXXMAXXMAXMXMMMMXMSAMXSASAMXMXSMSMXSMMMSXMAXMXMXXMASMMASXSAMASMXMAMXAMXMMSMASAMXSMMMSMMMSMMXMMASAMMSSMASAMXXMAMAMMMAAAAASM
MSAMASASMSSSXMMMMSSMAXMASAMXMSMSAMAXSASASMMMAMMAAXMMAXAAASASXMXSXMAMMMXSXSAMXSAMMASASMMMSAMASAMXSAXAAAAMAMAMMAMSAMAXAXAMASAMMMSMSXSSSMXMMSXA
MMMSXMASMMMMAMXXAASXXAMXAAXXMAMSAXXXSXMAXXAAAAXSMXSMSSSMMSAMMMAMMSMMAMASMMXMXMXSXXMASMXASASASMSAMMSXMSMSMSASXMXMMSSMMSMMMMAMXAAMSXMXXXAMXMMS
XAMXMMAMASXSAMAMMSSMMSSMSSSMSXXSAMSMMXSASXSSSMMASAAXMAXSXMMMSMASAAAMXMASXSASAXAMMMMSMMMMSXMASAMASAXXMXASMSXMAXXXXAXAAAXASXMMMSSXSASMXSXSASAM
MMMAMSSSMMASASAAMMXAAAAAAAAAMMAXAXSAMAMMXAAMAMSAMSXMAAMXMASAMXAMMSSMAMASAAAMAAXSAXXXASXAXMMMMXMXMASXMSMMASXSXMMMMMSMMMSMSAAXAXMASMMMMSMMASMM
MASAMSAMXMXMXSMSMAMMMSXMMXMMMAMSMASAMXSAMSMMAMMMMXMSMMSAMXMASMSSXAAMAMXMXMXMXMSAXSASAMMMSAAAMAMXMAMXAAAMXMASAMAAAAAAAAAASMMMSSMAMAAXAXAMAMAM
SASXSMMMXSMSAMXAMASXAXMSSXMAAXXMXMSMMASAMXASXSASMMASAMSXMXSXMAXMMSMMMSAMXXAXAMXMMMXMMMXXAXSSSSSXMSSMSMSSXSAMASXSSSSSMSMXMXSAMAMASMMSMSSMXSSM
MASXXXXXMMAMMMSASASMASAAAASXSSSMAXSXMAXXMSAMMSAMXMAMAMXMAXSAMXMXAAAAXMAMSXSSMSAXXXSXMASAAMXAAXAXSAMXMSAMXMAMXMAAAXAXAMXMSXMAMSMMMAXMMSAMXMAS
MAMMMSMSAMAMAXXAMAXAMMMMSXMAAAAXMSMMMMXMXAMXAMSMXMXSXMXXMAMXSAMMSSMMSXSMSAAAASASXXXASASASMMMMMXXMAXASMMSMSSMMMMMMMXMMMSSMMSSMAASXMMAXSAMXSAM
SSSMXAAAXXASMSMXMMMXXAXAXAMXMSMMXAAMMAASXXMSSXXMAMAMXMXMSSSMSAMMAXMASAMASMMMMMMAMASXMASAMXXXAAAMMSSMSMXSAAXAAMAMAXXAAAXAAAAAMXMMAASAMXSAMXMS
SAAXXMSMSSMSAXXAAAASXSSSSMMXAMXAMXMMMMMXAAXAMXMAXMSMAAMAAMAASAMMAXSAMAMAMAXMXAMAAXXXMAMAMMMSSSMSAXMAMXAMMMSSMMXSSMSXSSSXMMSSMSSMSMMAAXMSAMXS
MSMMSAAXMAMXMMMSSMXSAAAAAMMSSSMXSASXAXMMSMMASMMAXSASASMMXSMMMMMMAMMASXMXSXMXSXMMMMSMSASMMSAMAAAMASXMSMMSSMMMXXXXMASAMXMASAXAAAAMMXMMMMSAMXAS
XAMAAMSXSMMXXSXAAMSXMMMMMSAAAXAAMMMSASAAAAXSMXMAXSAMMXMSMSAMXAMXMXMXMAXAMAMXSMMSAASASMXMASMMXMMMXMASAMMAMAAAXXMSMSMMMASXMASXMSSMSSMSAMXXMMMS
SASMMXAASXMXMMMSSMAMSMXMAMMSMMMMMSAMXSMSSSMMASMMXMAMMSMAASAMSXXAXMAXMSMSSXXMXAAXMSMMMAXMXMASMSAMASXMAMMAXSMMSMAXMMAAMXMXXAMXMAMXAAXMASMXMAAX
SXMAXMMXMAXXSAAMAMXSAAAMASXXAMAAAMMSASXAAXAMXMASMMMMAMSMMSAMXSSSSSXSAXAMMMMMMMMSSXMAMXMSMXXMASASASMSSMXMXXAAMMSMMSSMSMMSMASMXXXMMSMSXMAASMMS
MMSXMASXSXMAXMXSSMSMMSMSMMMSMMMMSSSMMXMMSMSMAMXMMSMMXMSXXMAMAMSAAAAMXMAMAAAAASXMMAMXXMAAXSAMXSXMAMXXASXSAMMMSAMXXAMMAAXMSAMXXXXXXXAAAMMMXAXA
MAXAMXMASAMMSMMSXMAXMAMXMXMAMASXXXMASXAXXAMXSXMXXAAXMXXMSSMMAXMMMMMMMSSMSSSSSSXMMMMMMSSMMASMAXAXXMMMAXXMAMSAXXSMMMSSMXAXMXSMMSMMMMMSMMAXSSMX
MSSSMSAMSXMMAAXXAXAASASAMMXASAXAAXSAMXSAMXMAMASMSMSMSMAAMAASMMSASXXXXAMMMAMXMMMXASAAXAAXSAXXXMSMSAAMMAMMMMAAMXXAAAAAMMSXMASXAAAAXAMAMXXMAAXS
AXXMAXXXXXMSSSMSMMSASASXSASMMXSSSMMMSAMMSSMSMAMAAXMAASMMSXMMAXSAMXASMMSSMSMMAAXMASXMMSSMMASMSAAAXXXMXASASXXAMMXSMSMSXAXAMASMSSSMSSSMSAXMSMMA
MSMMAMSMMSAAAMAAXXXAMAMAMMSAAAXAXMASMASMMAAXMMMSMMMSMXMMXMMMXMMAMAMXSAAXAAAMSASXMMMXAMXAMXXAMSMSMMMMSXSASMSMAXXXAXAXMASAMXSAMAXMAMXXMAXMAAAS
XAAMAMAAASMMMMSMSMMXMAMAMXXMMMMMMMSMSAMASMMMXXAMXAAMXMSAMAAXSXSASXSAMMSMSSSMMAXXAAMXSMMXXAMSMAMAXAAAXAMAMASMMAMMAMMMAAMMXXMAMAMMXMXSSSSSMXXA
SSSMMSSMMMXXXAMXSAMASMSMSMXXXXAAAMMAMXSMMXMMXMASXMXSAMSASMMMSXXASAMXSXMMMXMXMXMXMXSAXAXSMSAASMSASXMMSXMAMMMAMXXMAMASMSSMSSSMMSSMSAXXAMAAAMSM
AXAXAAXASMMSAAMAMXSAXAAAAMMMMXSMSSMAMXAXMMAMXMMAMAAMAXSAMMSXSAMSMMMAMAAMXAMASMMASAMXSAMXAAXXXXMMXXAMXASXSSSMMSASXSAXXAAAAXAXAAAMAXMMMMSMMMAX
XMMMMSSXMAASMSMAXAMXSSMSMMAASXMSAMXAMXMAMSAMXSMAMMMSMMMXMXSAMXMAAXMASXMXMMMMXAXAMAMAXMMMSMMSSSSXXAMMXAMAMAAAAAMSXMASASMMMXSMMSMMMXXAMXMXAXSM
SMXAXXAXXMMMAMMSMASMXXAAMSSSSXMMXXSMXAXMASASAXMAMAXAAASMSXMAMMSMSMSAMMMXMAAXSMMMSSMXXAAAMAXXAAXMMSMAXMMMMSMMSSXSAAAMAMXMSAMXMMXSXMSSSMMSMSXS
SMASXXSSSSSMMMAMSMMAAMXMMAMAMAXMMMMMXSSMXSAMXSSMXXXSSMXAAMSSMAAXXAMASXAASXMMAAAAAAAASMMSSSSMMMMMAAMXSAAXAAAAMMAXMMXSAMXAMASXMAAXAAXMAAAXSMAA
XAAMXAAAXXAMXMAXAXXMMSAMMSSSSXMAASASAXAMAMXMXMASAMXXXMMMMXAXMXSMMXSAMMSXSASMSSMMSSMMXXAAXMXMXXSMSXXAAXXMSSMMSMSMSAMMMMMXSAMAMMMSMSXXSMMSAMMM
MMMSMMMMMSAMXSXSMSSXAXAMSAAXAMSMXSAMXMAMMXMAMSAMXAMMAMSMXMMSSMMMSAMASAMXSXMAAXXMXMAXMMMMSMMMMMMMXAMSSMXXAAAXAAMXMAXSMXSMMXSAMMXSMMXXXAXSAMSX
AAAXXAAAMXXMXSAAXAMMMSXMAMSMMAMMAMXMASXMSAAAAMMSMXAMAMXAMAXAAAAXMASMMXSAMMMMMMAXAMMMSXAAAAAXAMAAMAMMAMMMMMAMMSMMSSMAAASASASMMSASAMXMSMXXMMSX
SMSXSSSMSMMMAMMMMAMAAMXMSXXAXASMSMMSAMAASMMXSAAAAXSSSSXAMSMXSXMXSAMAXAMAMMAMAMMMSMSAXSXSSSMSSSSSSSMSAMMASMASAAAMAMXSMMMSMASAAMXMMMXMAXXXSAMM
XAMMMXXXMXAMXSAMXSSMXSAMAMXSMASXAAMMASMMMMXMMMSMXMAAAXXXMXMMMMSMMMSSMMSSMSASASMMMAMXXMMMMAXXMAXXXXASXXMAMSAMXSSMASXXAAXXMSMMMSMSAASXXSMMMASA
SASMSAMMMMMXAXAMAXAAXSMSASAMMXXMSXMMMMAXMSAASAMASMMMMMMSAMXASAMAAMAXAAXAASASASAAMAMSAXAAXXMMMSMMMMXMASMAMMXMAXAXAMASMMSAMXAXAAAMMMMXAMXAMXMM
SAAXMXMAAASMSSSMMSMAMSASASAXSMMMMXSAMSSMAXSSMAMAAXXAAAMAAMSMSASXMSMXMAMMMMAMXSMMSAMSASXSSMXXAAAAAAXMAMMXMASMMSAMXSXMMAMMASMMMMSMMSMMMSASMSMM
MSMXAASMSXSAAAASMXXAAMAMAMAMAAXSMASAMAAMSMMXMAMXSASMSSSSSMAASAMXXAXXSAMXAMXMAXAXSMXMAMAAMAXMSSSSSSSMASAMXAXAXMASAMAAMAMMAXAAXAAAAAAAAAAMXMAS
AXXSSMSXMMMMMSMMSAMSSMXMSMASXSMXMASXMSSMXXMASXSXXXSAMXMAMXMMMMMXSSMXAXMASXMMMSAMXSXASMMMMMSAMXXMAXXXXSASMSXSAMXXMSAMSSSMASXMSMSMSSSMSSSXASMM";

        public string Data
        {
            get { return data; }
        }

        public static Int32 BasicCount(string input)
        {
            var lines = input.Split("\r\n").ToList();
            return lines.ConvertAll(l => XMAS().Count(l)).Sum()
                + lines.ConvertAll(l => SMAX().Count(l)).Sum();
        }

        public static Int32 VerticalCount(string input)
        {
            var lines = input.Split("\r\n").ToList().ConvertAll(l => l.ToCharArray());
            var colonnes = new List<string>();
            for (var i = 0; i < lines[0].Length; i++)
            {
                colonnes.Add(string.Join("", lines.ConvertAll(l => l[i])));
            }
            return BasicCount(string.Join("\r\n", colonnes));
        }

        public static Int32 DiagonalRCount(string input)
        {
            var lines = input.Split("\r\n").ToList().ConvertAll(l => l.ToCharArray()).ToArray();
            var colonnes = new List<string>();
            var colonnesNumber = lines[0].Length;

            for (Int32 c = 0; c < colonnesNumber-3; c++)
            {
                var currentLine = "";
                for (Int32 j = 0; j < lines.Length && j + c < colonnesNumber; j++)
                {
                    currentLine += lines[c + j][j];
                }
                colonnes.Add(currentLine);
            }

            for (Int32 l = 1; l < lines.Length-3; l++)
            {
                var currentLine = "";
                for (Int32 j = 0; j < colonnesNumber && j + l < lines.Length; j++)
                {
                    currentLine += lines[j][l + j];
                }
                colonnes.Add(currentLine);
            }

            return BasicCount(string.Join("\r\n", colonnes));
        }

        public static Int32 DiagonalLCount(string input)
        {
            var lines = input.Split("\r\n").ToList().ConvertAll(l => l.ToCharArray()).ToArray();
            var colonnes = new List<string>();
            var colonnesNumber = lines[0].Length;

            for (Int32 c = colonnesNumber - 1; c >= 3; c--)
            {
                var currentLine = "";
                for (Int32 l = 0; l < lines.Length && c - l >= 0; l++)
                {
                    currentLine += lines[l][c - l];
                }
                colonnes.Add(currentLine);
            }

            for (Int32 l = lines.Length -4; l > 0; l--)
            {
                var currentLine = "";
                for (Int32 c = 0; c < colonnesNumber && l + c < lines.Length; c++)
                {
                    currentLine += lines[l + c][colonnesNumber-1 - c];
                }
                colonnes.Add(currentLine);
            }

            return BasicCount(string.Join("\r\n", colonnes));
        }

        public static Int32 CrossCount(string input)
        {
            var lines = input.Split("\r\n").ToList().ConvertAll(l => l.ToCharArray()).ToArray();
            var finded = 0;
            var colonnesNumber = lines[0].Length;
            var crossValues = new List<string>([
                "MSAMS", 
                "MMASS",
                "SSAMM",
                "SMASM",
                ]);
            for (Int32 l = 0; l < lines.Length - 2; l++)
            {
                for (Int32 c = 0; c < colonnesNumber - 2; c++)
                {
                    var cross = "" + lines[l][c] + lines[l][c + 2] + lines[l + 1][c + 1] + lines[l + 2][c] + lines[l + 2][c + 2];
                    if (crossValues.Contains(cross))
                    {
                        finded++;
                    }
                }
            }

            return finded;
        }

        public static Int32 TotalCount(string input)
        {
            var results = new ConcurrentBag<Int32>();
            Task.WaitAll([
                Task.Run(() => results.Add(BasicCount(input))),
                Task.Run(() => results.Add(VerticalCount(input))),
                Task.Run(() => results.Add(DiagonalRCount(input))),
                Task.Run(() => results.Add(DiagonalLCount(input))),
                ]);
            return results.Sum();
        }

        public static Int32 TotalCount2(string input)
        {
            return CrossCount(input);
        }

        [GeneratedRegex(@"XMAS")]
        private static partial Regex XMAS();
        [GeneratedRegex(@"SAMX")]
        private static partial Regex SMAX();
    }
}
