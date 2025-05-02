document.getElementById("change-pic").addEventListener("click", function() {
    const img = document.getElementById("switch");
    const type = document.getElementsByClassName("type")[0];
    const ig= document.getElementById("insta");
    const fb = document.getElementById("facebook");
    const git = document.getElementById("github");
    const tik = document.getElementById("git");
    
    
    if (img.src.includes("pic/ssa.png")) {
      img.src = "pic/wew.jpg";
      
        
        document.getElementById("ako").classList.toggle("changed");
        document.getElementsByClassName("gerald")[0].innerText = "Nicholine";
        document.getElementsByClassName("third-text")[0].innerText = "a Teacher";
        type.style.width = "0px";
        ig.href ="https://www.instagram.com/nicolayn_/";
        fb.href ="https://www.facebook.com/kathwannabee";
        git.href="https://www.tiktok.com/@nicolayn_";
        tik.style.backgroundImage = 'url("pic/tik.png")';
        
    } else {
      img.src = "pic/ssa.png";
      document.getElementById("ako").classList.toggle("changed");
      document.getElementsByClassName("gerald")[0].innerText = "Gerald";
      document.getElementsByClassName("third-text")[0].innerText = "a Wen Developer";
      type.style.width = "0px";
      ig.href ="https://www.instagram.com/jayrald._/";
      fb.href ="https://www.facebook.com/gerald.dimaano.9847/";
      git.href="https://github.com/pugeeeee/projects";
      tik.style.backgroundImage = 'url("pic/gh.png")';

    }
  });