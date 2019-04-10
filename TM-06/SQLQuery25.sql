select titles.title,max(royaltyper) as highest_royalty from titles join titleauthor on titleauthor.title_id=titles.title_id group by titles.title;
--select titles.title,max(royaltyper) from titles join titleauthor on titleauthor.title_id=titles.title_id where royaltyper in
--(select max(royaltyper) from titles join titleauthor on titleauthor.title_id=titles.title_id group by titles.title);
