/* Put your CSS here */

/******************************************************************
GENERAL LAYOUT STYLES
******************************************************************/

body {
    background: #ffffff;
    color: #ffffff;
    font-family: "runda";
    overflow-x: hidden;
    font-size: 14px;
    background: transparent url("Pepsized_Blur_24.jpg");
    /*42 24 74 88 89 99*/
}
.active { 
	font-weight: bold; 
	font-size: 18px;
  color: #346AA6;
 }
.container{
    /*margin: 1px auto;*/
    color: black;
    -moz-border-radius:7px;
    -webkit-border-radius:7px;
    border-radius:7px;
}
.topbar{
    width:auto; 
    display:block; 
    height:80px;
    background: transparent url("/img/StudioSabab/console.jpg") repeat;
    -moz-border-radius:7px;
    -webkit-border-radius:7px;
    border-radius:7px;
}
.tlt{
    color: #F0EADF;
    font-size: 20px;
    text-align: center;
    vertical-align: middle;
    font-family:Lucida Sans Unicode;
    position: relative; top: 30px;
}
.photos{cursor:}

/* Glisse: Overlay */
#glisse-overlay {
  background: rgba(0,0,0.3);}

#glisse-close {
  height: 40px;
  width: 40px;
  text-align: center;
  position: fixed;
  top:40px;
  right:40px;
  background:red;
}

/* Prev/Next button */
.glisse-next a, .glisse-prev a {
  width: 40px;
  height: 40px;
  display: block;
  position: fixed;
  bottom: 10px;
  background:green
}

.glisse-next a {
  left: 50%;
  margin-left: 20px; 
}

.glisse-prev a {
  left: 50%;
  margin-left: -40px; 
}

/* Legend */
.glisse-legend {
  position:fixed;
  display:block;
  bottom:10px;
  left:10px;
  background:blue; 
}
/******************************************************************
HEADLINES & TITLES
******************************************************************/

h1, .h1, h2, .h2, h3, .h3, h4, .h4, h5, .h5 { font-family: 'superclarendon', serif; font-weight: 500; }
h1 a, .h1 a, h2 a, .h2 a, h3 a, .h3 a, h4 a, .h4 a, h5 a, .h5 a { text-decoration: none; }
h1, .h1 { font-size: 2.5em; line-height: 1.333em; }
h2, .h2 { font-size: 17px; line-height: 21px; }
h3, .h3 { font-size: 1.125em; }
h4, .h4 { font-size: 1.1em; font-weight: 700; }
h5, .h5 { font-size: 0.846em; line-height: 2.09em; text-transform: uppercase; letter-spacing: 2px; }


/******************************************************************
HEADER SYTLES
******************************************************************/

header[role=banner] {
    height: 66px;
    width: 100%;
    border-top: 2px solid #444036;
    border-bottom: 2px solid #444036;
    margin-top: 2px;
    background: transparent url('header-bg.png') repeat;
    z-index: 999;
}
  header[role=banner] #logo {
      width: 125px;
      height: 127px;
      top: -30px;
  }
      header[role=banner] #logo a { background: transparent url('logo.png') no-repeat; }
      header[role=banner] #menu {
          font-size: 18px;
          text-transform: ;
          text-decoration: none;
          margin: 21px 0 0 162px;
      }
          header[role=banner] #menu ul {}
              header[role=banner] #menu ul li {
                  float: left;
                  /* padding-left: 21px; */
                  margin-right: 21px;
                  /* background: transparent url('library/images/lightning.png') no-repeat center left; */
              }
                  header[role=banner] #menu ul li a { text-decoration: none; }
  header[role=banner] aside { margin-top: 17px; }
  header[role=banner] aside p.btn {
      background-color: #327A2C;
      font-size: 13px;
      min-width: 40px;
  }
      header[role=banner] aside #top-tw {
          margin-left: 21px;
          min-width: 95px;
      }
          header[role=banner] aside #top-tw img {
              margin-right: 9px;
              margin-top: 8px;
          }
          header[role=banner] aside #top-tw p a { text-decoration: none; }
      header[role=banner] aside #top-fb { min-width: 85px; }
          header[role=banner] aside #top-fb img {
              margin-right: 9px;
              margin-top: 7px;
          }
          header[role=banner] aside #top-fb p a { text-decoration: none; }
                    
.sub-nav {
    width: 100%;
    height: 35px;
    top: 105px;
    text-transform: uppercase;
    background-color: #38352c;
    z-index: 998;
}
    .sub-nav ul { margin: 8px 0 0 200px; }
        .sub-nav ul li {
            float: left;
            margin-right: 18px;
        }
            .sub-nav ul li a { text-decoration: none; }

/******************************************************************
GRID STYLES
******************************************************************/

/* 960 Grid System (http://960.gs/ ) */
.nav-header{text-transform: none; text-align: center; font-size: 20px;}

/*********** JOSH CLASSES ***********/
/* DIMENSIONS */
.wide { width: 100%; }
.wrap { width: 980px; margin: 0 auto; }
.slide-wrap { width: 1900px; margin: 0 auto; }
.high { height: 100%; }
.slide-high { height: 845px; }

/* DISPLAYS */
.static { display: static; }
.block { display: block; }
.inline { display: inline; }
.none { display: none; }
.inline-block { display: inline-block; }

/* FLOATS & FIXES */
.left { float: left; position:fixed; left:10px;}
.middle{float: center;}
.right { float: right; }
.clear-left { clear: left; }
.clear-right { clear: right; }
.clear-none { clear: none; }
.clear { clear: both; }

/* POSITIONS */
.relative { position: relative; }
.absolute { position: absolute; }
.fixed { position: fixed; }

.offset-top { top: 0; }
.offset-bottom { bottom: 0; }
.offset-left { left: 0; }
.offset-right { right: 0; }
.offest-tl { top: 0; left: 0; }
.offest-tr { top: 0; right: 0; }
.offest-bl { bottom: 0; left: 0; }
.offest-br { bottom: 0; right: 0; }

/* MARGINS */
.alpha { margin-top: 0; }
.last { margin-right: 0; }
.omega { margin-bottom: 0; }
.first { margin-left: 0; }
.alpha-imp { margin-top: 0 !important; }
.last-imp { margin-right: 0 !important; }
.omega-imp { margin-bottom: 0 !important; }
.first-imp { margin-left: 0 !important; }
.first-alpha { margin-left: 0; margin-top: 0; }
.first-omega { margin-left: 0; margin-bottom: 0; }
.last-alpha { margin-right: 0; margin-top: 0; }
.last-omega { margin-right: 0; margin-bottom: 0; }
.first-last { margin-left: 0; margin-right: 0; }
.alpha-omega { margin-top: 0; margin-bottom: 0; }
.nom { margin: 0; }
.nom-imp { margin: 0 !important; }

/* PADDINGS */
.p-alpha { padding-top: 0; }
.p-last { padding-right: 0; }
.p-omega { padding-bottom: 0; }
.p-first { padding-left: 0; }
.p-first-alpha { padding-left: 0; padding-top: 0; }
.p-first-omega { padding-left: 0; padding-bottom: 0; }
.p-last-alpha { padding-right: 0; padding-top: 0; }
.p-last-omega { padding-right: 0; padding-bottom: 0; }
.p-first-last { padding-left: 0; padding-right: 0; }
.p-alpha-omega { padding-top: 0; padding-bottom: 0; }
.nop { padding: 0; }
.nop-imp { padding: 0 !important; }

/* TEXTS */
.sans { font-family: "runda", Verdana, sans-serif; }
.serif { font-family: 'superclarendon', serif; }
.sans-bold { font-family: "runda", Verdana, sans-serif; font-weight: bold; }
.serif-bold { font-family: 'superclarendon', serif; font-weight: bold; }
.largeFont { font-size: 24px; color: white;}

.antennabold {
  font-family: "runda", Verdana, sans-serif;
  font-style: normal;
  font-weight: 900;
}

.antennamedium {
  font-family: "runda", Verdana, sans-serif;
  font-style: normal;
  font-weight: 500;
}

.text-left { text-align: left; }
.text-right { text-align: right; }
.text-center { text-align: center; }

.uppercase { text-transform: uppercase; }
.lowercase { text-transform: lowercase; }
.not { text-decoration: none; }

.line-1 { line-height: 1; }
.nol { line-height: 0; }
.nob { border: 0 !important; }

/* MISC */
.no-list { list-style: none; }
.no-overflow { overflow: hidden; }
.ir {
    display: block;
    text-indent: -999em;
}

/*********** CSS3 ***********/
.text-shadow { /* change values */
  -webkit-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
    -moz-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
    -o-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
    text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
    filter: dropshadow(color=#000000, offx=1, offy=1);
}

.box-shadow { /* change values */
  -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
}

.help, .info, .error, .success { margin: 10px; padding: 5px 18px; border: 1px solid #cecece; }
.help { border-color: #E0C618; background: #EBE16F; }
.info { border-color: #92cae4; background: #d5edf8; }
.error { border-color: #fbc2c4; background: #fbe3e4; }
.success { border-color: #c6d880; background: #e6efc2; }
  
/******************************************************************
LINK STYLES
******************************************************************/

a, a:visited {
    color: #2224A6;
    -webkit-transition: color 0.2s ease-out;
    -moz-transition: color 0.2s ease-out;
    -ms-transition: color 0.2s ease-out;
    -o-transition: color 0.2s ease-out;
    transition: color 0.2s ease-out;
}
a:hover, a:focus { 
  color: #346AA6; 
}
a:active {
  color: #346AA6; 
} /* on click */
a:link { -webkit-tap-highlight-color : rgba(0,0,0,0); /* this highlights links on Iphones / iPads */ }

/******************************************************************
TEXT SELECTION STYLES
******************************************************************/

/* Highlighted Text */
::selection { 
  background: #6fc2f6; 
  color:#346AA6; 
  text-shadow : none; 
}

/* Firefox */
::-moz-selection { 
  background: #6fc2f6; 
  color:#0c0c0c; 
  text-shadow : none; 
}

/******************************************************************
WORDPRESS BODY CLASSES
want to style a page via body class? go ahead
******************************************************************/

.rtl {}
.home {} /* home page */
.blog {} 
.archive {} /* archive page */
.date {} /* date archive page */
  .date-paged-1 {} /* replace the number to the corresponding page number */
.search {} /* search page */
  .search-results {} /* search result page */
  .search-no-results {} /* no results search page */
  .search-paged-1 {} /* individual paged search (i.e. body.search-paged-3) */
.error404 {} /* 404 page */
.single {} /* single post page */
  .postid-1 {} /* individual post page by id (i.e. body.postid-73) */
  .single-paged-1 {} /* individual paged single (i.e. body.single-paged-3) */
.attachment {} /* attatchment page */
  .attachmentid-1 {} /* individual attatchment page (i.e. body.attachmentid-763) */
  .attachment-mime-type {} /* style mime type pages */
.author {} /* author page */
  .author-nicename {} /* user nicename (i.e. body.author-samueladams) */
  .author-paged-1 {} /* paged author archives (i.e. body.author-paged-4) for page 4 */
.category {} /* category page */
  .category-1 {} /* individual category page (i.e. body.category-6) */
  .category-paged-1 {} /* replace the number to the corresponding page number */
.tag {} /* tag page */
  .tag-slug {} /* individual tag page (i.e. body.tag-news) */
  .tag-paged-1 {} /* replace the number to the corresponding page number */
.page-template {} /* custom page template page */
  .page-template-page-php {} /* individual page template (i.e. body.page-template-contact-php */
  .page-paged-1 {} /* replace the number to the corresponding page number */
  .page-parent {}
  .page-child {}
  .parent-pageid-1 {} /* replace the number to the corresponding page number */
.logged-in {} /* if user is logged in */
.paged {} /* paged items like search results or archives */
  .paged-1 {} /* individual paged (i.e. body.paged-3) */

/******************************************************************
******************************************************************/

#content {}
#content[role="home"] {}
#content[role="single"],
#content[role="news"],
#content[role="media"] {
    min-height: 969px;
    background: transparent url('bg-inner.jpg') no-repeat top center fixed;
    /* -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover; */
}
#content[role="single"].bio {
    background: #FFF url('bio.jpg') no-repeat top center;
    background-size: initial;
}
#content[role="single"].bio.foundation {
    /* CHANGE THIS FOR FOUNDATION */
    background: #ECECEC url('library/images/foundationbg.jpg') no-repeat top center;
    background-size: initial;
}
    #content[role="home"] #slider * { z-index: -1; }
        #content[role="home"] #slider a.prev {
            position: absolute;
            top: 360px;
            left: 14px;
            z-index: 998;
            width: 51px;
            height: 52px;
            display: block;
            text-indent: -999em;
            background: transparent url('library/images/slide-prev.png') no-repeat;
        }
        #content[role="home"] #slider a.next {
            position: absolute;
            top: 360px;
            right: 14px;
            width: 51px;
            height: 52px;
            z-index: 998;
            display: block;
            text-indent: -999em;
            background: transparent url('library/images/slide-next.png') no-repeat;
        }
        #content[role="home"] #slider #the-thumbs {
            height: 60px;
            margin-top: -201px;
            z-index: 1;
        }
            #content[role="home"] #slider #the-thumbs div { margin-right: 28px; min-width: 196px; }
            #content[role="home"] #slider #the-thumbs aside {
                width: 42px;
                height: 45px;
                margin-left: 28px;
                background: transparent url('library/images/collapse.png') no-repeat center center;
                cursor: pointer;
            }
                #content[role="home"] #slider #the-thumbs div a {
                    float: left;
                    display: block;
                    border: 2px solid #bcb39c;
                    margin-left: 14px;
                    -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                    -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                    -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                    box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                }
        #content[role="home"] #slider #click-more {
            height: 525px;
            top: 112px;
            z-index: 8;
        }
    #content #single {
        margin-top: 140px;
        margin-bottom: 28px;
    }
    #content.bio #single {
        margin-top: 556px;
        margin-bottom: 28px;
    }
        #content #single #single-left,
        #content #single #comment-left,
        #content #single .single-left {
            width: 686px;
            background-color: #6a6761;
        }
        #content #single #comment-left,
        #content #single .single-left {
            min-height: 10px;
            margin-top: 28px;
            border-top: 7px solid #2C797A;
        }
        #content[role="media"] #single #comment-left,
        #content[role="media"] #single .single-left {
            min-height: 10px;
            margin-top: 28px;
            border-top: 7px solid #B8422B;
        }
        #content[role="single"] #single #single-left,
        #content[role="single"] #single #sidebar,
        #content[role="single"] #single #sidebar2,
        #content[role="single"] #single .single-left { border-top: 7px solid #2c797a; }
        #content[role="single"].bio #single #sidebar,
        #content[role="single"].bio #single #single-left,
        #content[role="single"].bio #single #sidebar2,
        #content[role="single"].bio #single .single-left,
        #content[role="single"].bio .sidebar {
            border-top: 7px solid #c36f42;
        }
            #content[role="single"].bio #single #sidebar2 ul,
            #content[role="single"].bio #single .single-left ul,
            #content[role="single"].bio #single #sidebar2 ol,
            #content[role="single"].bio #single .single-left ol,
            #content[role="single"].bio .sidebar ul,
            #content[role="single"].bio .sidebar ol {
                margin: 0 14px;
            }
            #content[role="single"].bio #single #sidebar h3,
            #content[role="single"].bio #single #sidebar2 h3,
            #content[role="single"].bio .sidebar h3 {
                font-size: 24px;
                padding-bottom: 14px;
                border-bottom: 2px solid #858175;
                margin-bottom: 14px;
            }
        #content[role="media"] #single #single-left,
        #content[role="media"] #single .single-left,
        #content[role="media"] #single #sidebar,
        #content[role="media"] #single #sidebar2,
        #content[role="media"] .sidebar { border-top: 7px solid #b8422b; }
      #content[role="media"] #single #single-left img {
        max-width: 630px;
        height: auto;
      }
            #content #single #single-left hgroup {
                padding: 14px 28px;
                background: #2F2C27 url('library/images/header-bg.png') repeat;
            }
                #content #single #single-left hgroup ul {}
                    #content #single #single-left hgroup ul li,
                    #content #single .single-left hgroup ul li {
                        font-size: 13px;
                        margin-right: 14px;
                        padding-right: 21px;
                        background: transparent url('library/images/breadcrumb.png') no-repeat right 2px;
                    }
                    #content #single #single-left hgroup ul li.last-imp,
                    #content #single .single-left hgroup ul li.last-imp { background: none; padding-right: 0; }
            #content #single #single-left aside,
            #content #single .single-left aside {
                padding: 10px 28px;
                background: #3b3832 url('library/images/header-bg.png') repeat;
            }
                #content #single #single-left aside a,
                #content #single .single-left aside a { color: #ACA9A2; margin-left: 21px; }
                #content #single #single-left aside a:hover,
                #content #single .single-left aside a:hover { color: #e5d7b5; }
            #content #single #single-left #post-itself,
            #content #single .single-left .post-itself { background: transparent url('library/images/single-bg.jpg') top no-repeat; }
                #content #single #single-left #post-itself address,
                #content #single .single-left .post-itself address,
                #content #single #sidebar address,
                #content #single #sidebar2 address,
                .sidebar address {
                    font-style: normal;
                    font-size: 19px;
                    line-height: 28px;
                    border-bottom: 2px solid #858175;
                    padding: 0 0 15px;
                    margin-bottom: 21px;
                }
                #content #single #single-left #post-itself article,
                #content #single .single-left .post-itself article { padding: 21px 28px; }
                #content #single #single-left #post-itself article figure.absolute,
                #content #single .single-left .post-itself article figure.absolute {
                    top: 14px;
                    right: 28px;
                }
                    #content #single #single-left #post-itself article article,
                    #content #single .single-left .post-itself article article {
                        padding: 0;
                        margin: 0 14px 14px 0;
                        border: 2px solid #BBB29D;
                    }
                    #content #single #single-left #post-itself article article:last-child,
                    #content #single .single-left .post-itself article article:last-child { margin-bottom: 0; }
                    #content #single #single-left #post-itself h2,
                    #content #single .single-left .post-itself h2 {
                        font-size: 42px;
                        line-height: 38px;
                        padding-bottom: 14px;
                        border-bottom: 2px solid #858175;
                        margin-bottom: 14px;
                    }
                    #content #single #single-left #post-itself p,
                    #content #single .single-left .post-itself p { font-size: 14px; }
                    #content #single #single-left #post-itself p iframe,
                    #content #single .single-left .post-itself p iframe {
                        width: 630px;
                        height: 354px;
                    }
                    #content #single #single-left #post-itself p:first-child,
                    #content #single .single-left .post-itself p:first-child { margin-top: 0; }
                    #content #single #single-left #post-itself p:last-child,
                    #content #single .single-left .post-itself p:last-child { margin-bottom: 0; }
        #content #single #sidebar,
        #content #single #sidebar2,
        .sidebar {
            padding: 28px;
            width: 203px;
            background-color: #413d37;
            margin-bottom: 28px;
        }
        #content #single #sidebar ul,
        #content #single #sidebar2 ul,
        #content #single #sidebar ol,
        #content #single #sidebar2 ol,
        .sidebar ul,
        .sidebar ol {
            margin-left: 14px;
            margin-bottom: 0;
        }
    #content #wall-blur {
        background: transparent url('library/images/wall-outer-bg.png') repeat-x;
        height: 336px;
        z-index: -1;
        top: 640px;
    }
    #content #wall {
        background: transparent url('library/images/wall-outer-bg.png') repeat-x top;
        margin-top: -77px;
        margin-bottom: 77px;
        min-height: 336px;
    }
        #content #wall-margin { margin-top: 28px; }
        #content[role="news"] #wall-margin,
        #content[role="single"] #wall-margin,
        #content[role="media"] #wall-margin { margin-top: 140px; }
            #content #wall-inner {
                background: #413d37 url('library/images/wall-bg.jpg') repeat-x top;
                margin-bottom: 21px;
            }
                #content #wall-inner hgroup {
                    margin: 28px 28px 21px 28px;
                    border-bottom: 2px solid #8c7e5b;
                }
                    #content #wall-inner hgroup h2 {
                        margin-bottom: 14px;
                        font-size: 48px;
                    }
            #content[role="home"] #wall-inner { border-top: 7px solid #327a2c; }
            #content[role="news"] #wall-inner { border-top: 7px solid #2c797a; }
            #content[role="media"] #wall-inner { border-top: 7px solid #b8422b; }
            #content[role="news"].team #wall-inner {
                border-top: 7px solid #D79b46;
                padding-bottom: 21px;
            }
                #content #wall-inner nav { margin: 0 28px 7px 28px; }
                    #content #wall-inner nav ul {}
                        #content #wall-inner nav ul li { float: left; }
                            #content #wall-inner nav ul li a {
                                text-decoration: none;
                                padding: 7px 10px;
                                margin-right: 7px;
                                -webkit-border-radius: 3px;
                                -moz-border-radius: 3px;
                                -o-border-radius: 3px;
                                border-radius: 3px;
                                -webkit-transition: background-color 0.2s ease-out;
                                -moz-transition: background-color 0.2s ease-out;
                                -ms-transition: background-color 0.2s ease-out;
                                -o-transition: background-color 0.2s ease-out;
                                transition: background-color 0.2s ease-out;
                            }
                            #content #wall-inner nav ul li a:hover, .active {
                                -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                                -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                                -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                                box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                            }
                            #content[role="home"] #wall-inner nav ul li a:hover,
                            #content[role="home"] .active {
                                color: #ececec;
                                background-color: #327a2c;
                            }
                            #content[role="news"] #wall-inner nav ul li a:hover,
                            #content[role="news"] .active {
                                color: #ececec;
                                background-color: #2c797a;
                            }
                            #content[role="media"] #wall-inner nav ul li a:hover,
                            #content[role="media"] .active {
                                color: #ececec;
                                background-color: #b8422b;
                            }

                #content #wall-inner #wall-itself {
                    margin: 0 14px;
                    display: none;
                }
                    #wall-itself .wall-post,
                    #sidebar .wall-post {
                        width: 210px;
                        margin: 14px;
                        float: left;
                        background-color: #6a6761;
                        -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                        -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                        -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                        box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
                    }
                    #wall-itself .wall-post div.theHover,
                    #sidebar .wall-post div.theHover,
                    #post-itself div.theHover {
                        width: 100%;
                        height: 100%;
                        background: transparent url('library/images/figure-hover.png') no-repeat center center;
                        opacity: 0;
                        -webkit-transition: opacity 0.2s ease-out;
                        -moz-transition: opacity 0.2s ease-out;
                        -ms-transition: opacity 0.2s ease-out;
                        -o-transition: opacity 0.2s ease-out;
                        transition: opacity 0.2s ease-out;
                    }
                    #sidebar .wall-post div.theHover:hover,
                    #wall-itself .wall-post div.theHover:hover,
                    #post-itself div.theHover:hover { opacity: 1; }
                    #sidebar .wall-post { margin: 0 0 28px 0; }
                        #wall-itself .wall-post figure,
                        #sidebar .wall-post figure {
                            border: 2px solid #BBB29D;
                            min-height: 200px;
                            background: transparent url('library/images/figure-hover.png') no-repeat center center;
                        }
                            #wall-itself .wall-post figure img,
                            #sidebar .wall-post figure img {
                                margin: 0;
                                padding: 0;
                            }
                        #wall-itself .wall-post h2,
                        #sidebar .wall-post h2 {
                            padding: 0;
                            margin: 14px 14px 7px 14px;
                        }
                        #wall-itself .wall-post time,
                        #sidebar .wall-post time {
                            font-size: 13px;
                            font-weight: 400;
                            margin: 0 14px 14px 14px;
                            padding: 0;
                            color: #aca9a2;
                        }
                            #wall-itself .wall-post time a,
                            #sidebar .wall-post time a {
                                color: #aca9a2;
                                text-decoration: none;
                            }
                            #wall-itself .wall-post time a:hover,
                            #sidebar .wall-post time a:hover { color: #e5d7b5; }
                        #wall-itself .wall-post p,
                        #sidebar .wall-post p {
                            font-size: 13px;
                            padding: 7px 0 0 0;
                            margin: 0 14px 14px 14px;
                            border-top: 2px solid #858175;
                            -webkit-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
                            -moz-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
                            -o-text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
                            text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
                            filter: dropshadow(color=#000000, offx=1, offy=1);
              word-wrap: break-word;
                        }
                    #wall-itself .wall-post.sticky { width: 448px; }
                    #wall-itself .wall-post.image aside {
                        width: 33px;
                        height: 36px;
                        background: transparent url('library/images/image-icon.gif') no-repeat center center;
                        margin: 0;
                        padding: 0;
                        bottom: -2px;
                        right: -2px;
                    }
                    #wall-itself .wall-post.photos aside {
                        width: 33px;
                        height: 36px;
                        background: transparent url('library/images/album-icon.gif') no-repeat center center;
                        margin: 0;
                        padding: 0;
                        bottom: -2px;
                        right: -2px;
                    }
                    #wall-itself .wall-post.video aside {
                        width: 33px;
                        height: 36px;
                        background: transparent url('library/images/video-icon.gif') no-repeat center center;
                        margin: 0;
                        padding: 0;
                        bottom: -2px;
                        right: -2px;
                    }
                    #content[role=media] #wall-itself .wall-post.video aside {
                        /* bottom: 0;
                        right: 0; */
                    }
                    #wall-itself .wall-post.facebook { display: none; }
                    #wall-itself .wall-post.facebook p {
                        padding-top: 14px;
                        white-space: pre;
                        white-space: pre-wrap;
                        word-wrap: break-word;
                    }
          #wall-itself .wall-post.facebook p a {
                        text-decoration: none;
                    }
                    #wall-itself .wall-post.facebook aside {
                        width: 13px;
                        height: 21px;
                        background: transparent url('library/images/facebook-icon.png') no-repeat center center;
                        margin: 0;
                        padding: 0;
                        bottom: 18px;
                        right: 18px;
                    }
                    #wall-itself .wall-post.facebook pre {
                        font-family: "runda", Verdana, sans-serif;
                        font-style: normal;
                        font-weight: 500;
                    }
                #wall-inner aside {
                    margin: 28px;
                    padding: 0 0 28px 0;
                }

.btn {
    font-size: 14px;
    font-family: "runda", Verdana, sans-serif;
    font-weight: 900;
    color: #ECECEC;
    text-transform: uppercase;
    text-decoration: none;
    padding: 7px 10px;
    background-color: #6a6761;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    -o-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -webkit-transition: background-color 0.2s ease-out;
    -moz-transition: background-color 0.2s ease-out;
    -ms-transition: background-color 0.2s ease-out;
    -o-transition: background-color 0.2s ease-out;
    transition: background-color 0.2s ease-out;
}
.btn:hover { color: #ECECEC; }
#content[role="home"] .btn:hover { background-color: #327a2c; }
#content[role="news"] .btn:hover { background-color: #2c797a; }
#content[role="media"] .btn:hover { background-color: #b8422b; }
.w686 { width: 686px; }
                
/******************************************************************
POSTS & CONTENT STYLES
******************************************************************/

    
    /* post content */
    .post_content {}
      
      .post_content p { margin: 0 0 1.5em 0; line-height: 1.5em; }
      .post_content ul, .post_content ol, .post_content table, .post_content dl { margin: 1.5em 0; }
      .post_content ul, .post_content ol { list-style-position:outside; line-height:1.5; margin-left: 2.2em; margin-right: 2.2em; }
      .post_content li { margin-bottom: 0.75em; }
      .post_content ul li { list-style-type: disc; }
      .post_content ol li { list-style-type: decimal; }
      
      .post_content blockquote { font-style:italic; line-height:1.6em; margin: 1.5em 2.2em; }
      .post_content blockquote:before { font-family:Georgia, serif; content: "“"; font-size:2.75em; text-indent:-.8em; margin-top:.1em; float:left; opacity:.3; } /* this adds the quote before the blockquote */
      
      .post_content dl { margin:1.75em 0 1.75em; }
      .post_content dt { margin-top: 1.25em; font-weight:700; }
      .post_content dd { font-style: italic; margin-top:0.5em; line-height:1.6em; }
      
      .post_content img { margin: 0 0 1.5em 0; max-width: 100%; }
      .alignleft, img.alignleft { margin-right: 1.5em; display: inline; float: left; }
      .alignright, img.alignright { margin-left: 1.5em; display: inline; float: right; }
      .aligncenter, img.aligncenter { margin-right: auto; margin-left: auto; display: block; clear: both; }
      
      .post_content video { margin: 1.5em 0; max-width: 100%; display: block; }
      .post_content object { display: block; margin: 1.5em 0; max-width: 100%; }
      .post_content pre, .post_content code { font-size: 0.9em; line-height: 1.7em; padding: 1em; background: #eee; border: 2px solid #cecece; }
      
      .wp-caption { margin-bottom: 1.5em; text-align: center; padding-top: 5px; }
      .wp-caption img { border: 0 none; padding: 0; margin: 0; }
      .wp-caption .wp-caption-text { font-size:0.8em; font-style:italic; margin:.6em 0 -.2em; }
      
      /* image gallery styles */
      .gallery dl {}
      .gallery dt {}
      .gallery dd {}
      .gallery dl a {}
      .gallery dl img {}
      .gallery-caption {}
      
      .size-full { width: 100%; }
      .size-large { width: 100%; }
      .size-medium { width: 100%; }
      .size-thumbnail {}
      
    .hentry footer { clear: both; margin: 1.5em 0 0; padding-bottom: 2.2em; }
  
  
/******************************************************************
PAGE NAVI STYLES
(Special Feature)
******************************************************************/

/* page navigation */
.page-navigation, .wp-prev-next { margin: 1.1em 0 2.2em; }
  .bones_page_navi, .wp-prev-next ul { }
    .bones_page_navi li { float: left; margin-left: 10px; } 
      .bones_page_navi li a { padding: 3px 6px; display: block; text-decoration: none; position: relative; }
        .bones_page_navi li a:hover { color: #f01d4f; text-decoration: underline; }
    .bones_page_navi li.bpn-current { padding: 3px 6px; border-bottom: 2px solid #f01d4f; position: relative; } /* current page link */
        .bones_page_navi li.bpn-current:hover {}
    .bones_page_navi li.bpn-prev-link { } /* previous link */
      .bones_page_navi li.bpn-prev-link a { padding: 0; }
        .bones_page_navi li.bpn-prev-link a:hover { background: none; }
    .bones_page_navi li.bpn-next-link { font-weight: 700; } /* next page link */
      .bones_page_navi li.bpn-next-link a { padding: 0; }
        .bones_page_navi li.bpn-next-link a:hover { background: none; }
    .bones_page_navi li.bpn-last-page-link {} /* last page link */
      .bones_page_navi li.bpn-last-page-link a {}
        .bones_page_navi li.bpn-last-page-link a:hover { background: none; }
    .bones_page_navi li.bpn-first-page-link {} /* first page link */
      .bones_page_navi li.bpn-first-page-link a {}
        .bones_page_navi li.bpn-first-page-link a:hover { background: none; }
  
  /* fallback previous & next links */
  .wp-prev-next {}
    .wp-prev-next ul {}
      .wp-prev-next .prev-link { float: left; }
      .wp-prev-next .next-link { float: right; }

  
/******************************************************************
COMMENT STYLES
******************************************************************/

#comments { margin: 0 20px 0.75em; }/* h3 comment title */
  #comments span { font-weight: 700; color: #1a90db; } /* number of comments span */
  
.comment-nav {}
  .comment-nav ul {}
    .comment-nav ul li {}
    
.commentlist { margin: 0 20px; }
  .commentlist li { position: relative; clear: both; list-style-type: none; margin-bottom: 1.5em; padding: 0.7335em 10px; }
    .commentlist li[class*=depth-] { padding-left: 20px; margin-top: 1.1em; }
      .commentlist li.depth-1 { margin-left: 0; margin-top: 0; }
        .commentlist li:not(.depth-1) { margin-right: -10px; margin-top: 0; padding-bottom: 0; }
      .commentlist li.depth-2 {}
      .commentlist li.depth-3 {}
      .commentlist li.depth-4 {}
      .commentlist li.depth-5 {}
      .commentlist li:last-child { margin-bottom: 0; }
        .commentlist li ul.children li {}
        .commentlist li ul.children li.alt {}
        .commentlist li ul.children li.byuser {}
        .commentlist li ul.children li.comment {}
        .commentlist li ul.children li.depth-1 {} /* change number for different depth */
        .commentlist li ul.children li.bypostauthor {}
        .commentlist li ul.children li.comment-author-admin {}
        .commentlist li ul.children .alt {}
        .commentlist li ul.children .odd {}
        .commentlist li ul.children .even {}
      .commentlist .alt {}
      .commentlist .odd { background: #eee; }
      .commentlist .even { background: #fefefe; }
      .commentlist .parent {}
      .commentlist .comment {}
      .commentlist .children { border-left: 2px solid #6ac8d3; }
      .commentlist .pingback {}
      .commentlist .bypostauthor {}
      .commentlist .comment-author {}
      .commentlist .comment-author-admin {}
      .commentlist .thread-alt {}
      .commentlist .thread-odd {}
      .commentlist .thread-even {}  
      
      .commentlist .vcard { margin-left: 55px; }
        .commentlist .vcard cite.fn { font-weight: 700; font-style: normal; }
        .commentlist .vcard time { float: right; }
          .commentlist .vcard time a { color: #999; text-decoration: none; }
            .commentlist .vcard time a:hover { text-decoration: underline; }
        .commentlist .vcard img.photo {}
        .commentlist .vcard img.avatar { position: absolute; left: 20px; padding: 2px; border: 1px solid #cecece; background: #fff; }
          .commentlist .vcard cite.fn a.url {}
        .commentlist .comment-meta {} 
          .commentlist .comment-meta a {}
        .commentlist .commentmetadata {}
          .commentlist .commentmetadata a {}
      .commentlist li .comment_content { margin-left: 55px; }
        .commentlist li .comment_content p { margin: 0.7335em 0 1.5em; font-size: 1em; line-height: 1.5em; }
        .commentlist li ul { margin: 0; }   
        .commentlist .comment-reply-link { text-decoration: none; float: right;  background: #4598bb; padding: 3px 5px; color: #fff; opacity: 0.65; margin-bottom: 10px; font-weight: 700; font-size: 0.9em; }
          .commentlist a.comment-reply-link:hover { opacity: 1; }
      
        
/******************************************************************
COMMENT FORM STYLES
******************************************************************/

.respond-form { margin: 1.5em 20px; padding-bottom: 2.2em; }
  #comment-form-title { margin: 0 0 1.1em; }
  
  #cancel-comment-reply {}
      #cancel-comment-reply a {}
      
  .respond-form form[method=post] { margin: 0.75em 0; }
    
    .comments-logged-in-as {}
    
    .respond-form form[method=post] li { list-style-type: none; clear: both; margin-bottom: 0.7335em; }
      .respond-form form[method=post] li label, .respond-form form[method=post] li small { display: none; }
      .respond-form input[type=text], .respond-form input[type=email], .respond-form input[type=url], .respond-form textarea { padding: 3px 6px; background: #efefef; border: 2px solid #cecece; line-height: 1.5em; }
      .respond-form input[type=text]:focus, .respond-form input[type=email]:focus, .respond-form input[type=url]:focus, .respond-form textarea:focus { background: #fff; }
      .respond-form input[type=text], .respond-form input[type=email], .respond-form input[type=url] { max-width: 400px; min-width: 250px; }
      
      #allowed_tags { margin: 1.5em 10px 0.7335em 0; }
      .respond-form textarea { resize: none; width: 97.3%; height: 150px; }
      #submit {}
    
  /* form validation */
  .respond-form input:invalid, .respond-form textarea:invalid { border-color: #fbc2c4; background: #fbe3e4; outline: none; box-shadow: none; -webkit-box-shadow: none; -moz-box-shadow: none; background-color: #f6e7eb; }    
  
  /* no comments */
  .nocomments { margin: 28px; }     

/******************************************************************
SIDEBARS & ASIDES
******************************************************************/

#sidebar {}

/******************************************************************
FOOTER STYLES
******************************************************************/

footer[role=contentinfo] {}
    footer[role=contentinfo] #ad-sel {
        height: 112px;
        background: #2f2c27 url('library/images/header-bg.png') repeat;
    }
        footer[role=contentinfo] #ad-sel .wrap {
            margin-top: 28px;
        }
            footer[role=contentinfo] #ad-sel .sel-itself {
                border: 2px solid #bcb39c;
                margin-right: 18px;
                display: inline-block;
                vertical-align: middle;
            } footer[role=contentinfo] #ad-sel .sel-itself:last-child { margin-right: 0px; }
                footer[role=contentinfo] #ad-sel .sel-itself img {
                    opacity: 0;
                    -webkit-transition: opacity 0.2s ease-out;
                    -moz-transition: opacity 0.2s ease-out;
                    -ms-transition: opacity 0.2s ease-out;
                    -o-transition: opacity 0.2s ease-out;
                    transition: opacity 0.2s ease-out;
                }
                footer[role=contentinfo] #ad-sel .sel-itself img:hover,
                footer[role=contentinfo] #ad-sel .sel-itself a.activeAd img { opacity: 1; }
            #sel-puma { background: transparent url('library/images/puma-0.png') no-repeat; }
            #sel-gatorade { background: transparent url('library/images/gatorade-0.png') no-repeat; }
            #sel-digicel { background: transparent url('library/images/digicel-0.png') no-repeat; }
            #sel-regupol { background: transparent url('library/images/regupol-0.png') no-repeat; }
            #sel-hublot { background: transparent url('library/images/hublot-0.png') no-repeat; }
            #sel-soul { background: transparent url('library/images/soul-0.png') no-repeat; }
            #sel-virgin { background: transparent url('library/images/virgin-0.png') no-repeat; }
            #sel-visa { background: transparent url('library/images/visa-0.png') no-repeat; }
            #sel-nissan { background: transparent url('library/images/nissan-0.png') no-repeat; }
    footer[role=contentinfo] #ads {
        height: 176px;
        background: #3b3832 url('library/images/header-bg.png') repeat;
    }
        footer[role=contentinfo] #ads .ad-itself {
            width: 920px;
            height: 115px;
            border: 2px solid #bcb39c;
            margin: 28px;
        }
    footer[role=contentinfo] #copy {
        height: 196px;
        background: transparent url('library/images/copy-bg.gif');
        -webkit-background-size: cover;
        -moz-background-size: cover;
        -o-background-size: cover;
        background-size: cover;
    }
        footer[role=contentinfo] #copy .left,
        footer[role=contentinfo] #copy .right { margin-top: 42px; }
            footer[role=contentinfo] #copy .left a {
                float: left;
                text-transform: uppercase;
                text-decoration: none;
                color: #6a6761;
                margin-left: 14px;
            }
            footer[role=contentinfo] #copy .left a:hover { color: #e5d7b5; }
            footer[role=contentinfo] #copy .right p { color: #cbcbcb; }
                footer[role=contentinfo] #copy .right p img {
                    float: right;
                    margin: -14px 14px;
                }
  
/******************************************************************
MEDIA QUERIES & DEVICE STYLES
To use a responsive design, it's reccomended to use the responsive version of Bones. You can find it on github: https://github.com/eddiemachado/bones-responsive
******************************************************************/

@media only screen and (min-width: 480px) {
  /* insert styles here */
}

@media only screen and (min-width: 768px) {
/* insert styles here */
}

@media only screen and (min-width: 992px) {
/* insert styles here */
}

@media only screen and (min-width: 1382px) {
/* insert styles here */
}

@media only screen and (-webkit-min-device-pixel-ratio: 2), only screen and (min-device-pixel-ratio: 2) {
/* insert styles here */
}

/******************************************************************
PRINT STYLES
(Handled by default, but if you want to edit it, feel free)
******************************************************************/

@media print { }

/******************************************************************
IE SPECIFIC FIXES
******************************************************************/

/**** Isotope Filtering ****/

.isotope-item {
  z-index: 2;
}

.isotope-hidden.isotope-item {
  pointer-events: none;
  z-index: 1;
}

/**** Isotope CSS3 transitions ****/

.isotope,
.isotope .isotope-item {
  -webkit-transition-duration: 0.8s;
     -moz-transition-duration: 0.8s;
      -ms-transition-duration: 0.8s;
       -o-transition-duration: 0.8s;
          transition-duration: 0.8s;
}

.isotope {
  -webkit-transition-property: height, width;
     -moz-transition-property: height, width;
      -ms-transition-property: height, width;
       -o-transition-property: height, width;
          transition-property: height, width;
}

.isotope .isotope-item {
  -webkit-transition-property: -webkit-transform, opacity;
     -moz-transition-property:    -moz-transform, opacity;
      -ms-transition-property:     -ms-transform, opacity;
       -o-transition-property:         top, left, opacity;
          transition-property:         transform, opacity;
}

/**** disabling Isotope CSS3 transitions ****/

.isotope.no-transition,
.isotope.no-transition .isotope-item,
.isotope .isotope-item.no-transition {
  -webkit-transition-duration: 0s;
     -moz-transition-duration: 0s;
      -ms-transition-duration: 0s;
       -o-transition-duration: 0s;
          transition-duration: 0s;
}

.gform_wrapper .left_label .gfield_label {
    float: left;
    margin: 2px 15px 0 0;
    width: 29%;
    font-weight: bold;
}
.gform_wrapper input, .gform_wrapper textarea {
    display: block;
  padding: 7px;
  font-size: 14px;
  border: 1px solid #ddd;
  background: #f5f5f5;
  -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -moz-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  border-radius: 2px;
    opacity: 0.7;
    -webkit-transition: opacity 0.2s ease-out;
    -moz-transition: opacity 0.2s ease-out;
    -ms-transition: opacity 0.2s ease-out;
    -o-transition: opacity 0.2s ease-out;
    transition: opacity 0.2s ease-out;
}
.gform_wrapper textarea {
    display: block;
  padding: 7px;
  font-size: 14px;
  border: 1px solid #ddd;
  background: #f5f5f5;
  -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -moz-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,.05);
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  border-radius: 2px;
}
.gform_wrapper input:hover, .gform_wrapper textarea:hover { opacity: 0.8; }
.gform_wrapper input:active, .gform_wrapper textarea:active,
.gform_wrapper input:focus, .gform_wrapper textarea:focus { opacity: 1; }
/*.gform_wrapper .button {
    margin: 0;
  padding: 5px 10px;
  font-size: 13px;  
  font-weight: bold;
  border: 1px solid #ccc;
  background: #eee;
  -webkit-border-radius: 2px;
  -moz-border-radius: 2px;
  border-radius: 2px;
}
.gform_wrapper .button:hover,
.gform_wrapper .button:focus {
    border: 1px solid #bbb;
    background: #e5e5e5;
}*/
.gform_wrapper .button,
.wp-pagenavi * {
    font-size: 14px;
    font-family: "runda", Verdana, sans-serif;
    font-weight: 900;
    color: #ECECEC !important;
    text-transform: uppercase;
    text-decoration: none;
    padding: 10px 14px;
    background-color: #858175 !important;
    -webkit-border-radius: 3px !important;
    -moz-border-radius: 3px !important;
    -o-border-radius: 3px !important;
    border-radius: 3px !important;
    border: none !important;
    opacity: 1;
    -webkit-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -moz-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -o-box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    box-shadow: 0px 3px 0px 0px rgba(0, 0, 0, 0.2);
    -webkit-transition: background-color 0.2s ease-out;
    -moz-transition: background-color 0.2s ease-out;
    -ms-transition: background-color 0.2s ease-out;
    -o-transition: background-color 0.2s ease-out;
    transition: background-color 0.2s ease-out;
}
.wp-pagenavi * { padding: 4px 8px !important; }
.gform_wrapper .button:hover,
.wp-pagenavi a:hover,
.wp-pagenavi .current {
    background-color: #2C797A !important;
    opacity: 1;
}
#content[role=media] .wp-pagenavi a:hover,
#content[role=media] .wp-pagenavi .current {
    background-color: #B8422B !important;
    opacity: 1;
}
#pagenavi {
    padding: 21px 0 0 0 !important;
    border-top: 2px solid #8C7E5B;
}
#disqus_thread { padding: 28px; }
.dark .discovery-unit a.top-comment .user { color: #fff !important; }
