document.addEventListener('DOMContentLoaded', () => {
  // تحميل navbar
  fetch('navbar.html')
    .then(response => {
      if (response.ok) {
        console.log("nada: ");
        return response.text();
      }
      throw new Error("Failed to load navbar.html");
    })
    .then(data => {
      console.log("Navbar loaded successfully");
      document.getElementById('navbar').innerHTML = data;
      setActiveLink();  
    })
    .catch(error => {
      console.error("Error loading navbar:", error);
    });

  // تحميل footer
  fetch('footer.html')
    .then(response => response.text())
    .then(data => {
      document.getElementById('footer').innerHTML = data;
    });

  // تفعيل الرابط النشط
  function setActiveLink() {
    const currentPath = window.location.pathname; 
    const navLinks = document.querySelectorAll('.nav-links a'); 
    const dropdownLink  = document.querySelector('.dropdown-t'); 

    navLinks.forEach(link => {
      let linkPath = link.getAttribute('href'); 

      if (linkPath.startsWith('./')) {
        linkPath = linkPath.substring(2); 
      }

      link.classList.remove('active'); 
      
      if (currentPath === linkPath || currentPath.startsWith(linkPath) || currentPath.includes(linkPath)) {
        if (link.closest('.dropdown-menu')) {
          dropdownLink.classList.add('active'); 
        }else{
          link.classList.add('active');
        }
        
      }
    });
  }
});


function toggleMenu() {
  const navLinks = document.querySelector('.nav-links');
  navLinks.classList.toggle('active');
}
function redirectToSignUp() {
  window.location.href = "./sing_up.html";
}