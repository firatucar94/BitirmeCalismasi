%%%%%B�LEC�K �EYH EDEBAL� �N�VERS�TES� M�HEND�SL�K FAK�LTES�%%%%%
%B�LG�SAYAR M�HEND�SL��� B�T�RME �ALI�MASI LATEX �ABLONU
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\def\fileversion{1.1}
\def\filedate{19/12/2014}
\NeedsTeXFormat{LaTeX2e}
\ProvidesClass{BUB}[\filedate\space Version \fileversion\space 
by Dr.Salim CEYHAN]
\DeclareOption*{%
  \PassOptionsToClass{\CurrentOption}{article}%
}
\ProcessOptions\relax
\LoadClass[a4paper,12pt]{article}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage[turkish]{babel}%latex'de i�indekiler,�ekiller gibi 
%%ba�l�klar� t�rk�ele�tirir.
\RequirePackage[latin5]{inputenc}%T�rk�e harf paketi
\RequirePackage[T1]{fontenc}%T�rk�e hecelemeyi do�ru bi�imde yapar
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{times}%Matematikte ve metinde Times Roman versiyonu; 
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{tikz}
\usetikzlibrary{mindmap}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%Sayfa ayarlar�n� yapar.
\RequirePackage[left=4cm,right=2cm,top=3cm,bottom=3cm]{geometry}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{amssymb,amsmath,amsthm}%�zel matematik yaz� fontlar�
\RequirePackage{graphics,graphicx}%grafik paketlerini �a��r�r
\RequirePackage{float}%Grafi�in veya resmin sayfan�n istenen 
%%yerinde olmas�n� sa�lar.
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% 
%%i��NDEK�LER� B�Y�K HARF YAPTIK
\addto\captionsturkish{\renewcommand\contentsname{���NDEK�LER}}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%�ekil, tablo ve denklem numaralar�n� b�l�mlere g�re numaralar
\RequirePackage{caption}
\numberwithin{equation}{section}
\numberwithin{figure}{section}
\numberwithin{table}{section}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{tocloft}
\renewcommand{\cftfigfont}{�ekil\;}
\renewcommand{\cfttabfont}{Tablo\;}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{cite}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{datetime}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{multirow}%Tablolar i�in �zel komutlar� �a��r�r.
\RequirePackage{setspace}%sat�r bo�luklar� i�in �zel komutlar� �a��r�r
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{indentfirst}
\RequirePackage{parskip}
\setlength{\parindent}{0.5cm}%paragraf girintisi
\renewcommand{\baselinestretch}{1.5}
%T�m metnin sat�r aral�klar�n� 1.5 aral�k yapar.
\setlength{\parskip}{\baselineskip}
%%%%%%%%%%%%%%%Filigran Ekleme%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%Yaln�z ilk sayfaya Filigran koyan kod.(*-dan dolay� yaln�z 
%%ilk sayfaya ekledi)%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{eso-pic}
\RequirePackage{color}
\AddToShipoutPicture*{%
\scalebox{1.3}
{\put(0,-150)
{\includegraphics[height=297mm,width=210mm]{filigran}}}}
%% lof/lot'u Toc'a ekleme paketi%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{tocloft}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
\RequirePackage{totpages}%
%Metnin toplam print edilecek sayfa say�s�n� verir.
\RequirePackage{verbatim}
\flushbottom%
% t�m metin sayfalar�n�n ayn� y�kseklikte olmas�n� sa�lar.
\RequirePackage[pdftex, unicode, linktoc=all, hidelinks, breaklinks]{hyperref}
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%